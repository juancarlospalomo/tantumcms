﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultPageListService.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using BetterModules.Core.DataAccess.DataContext;
using BetterCms.Core.DataContracts.Enums;
using BetterCms.Core.Security;
using BetterCms.Module.Pages.Content.Resources;
using BetterCms.Module.Pages.Models;
using BetterCms.Module.Pages.ViewModels.Filter;
using BetterCms.Module.Pages.ViewModels.SiteSettings;

using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.Mvc;
using BetterCms.Module.Root.Mvc.Grids.Extensions;
using BetterCms.Module.Root.Services;
using BetterCms.Module.Root.ViewModels.Category;

using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace BetterCms.Module.Pages.Services
{
    public class DefaultPageListService : IPageListService
    {
        private readonly ICategoryService categoryService;

        private readonly ILanguageService languageService;

        private readonly ILayoutService layoutService;

        private readonly ICmsConfiguration configuration;

        private readonly IAccessControlService accessControlService;

        private readonly IUnitOfWork unitOfWork;

        public DefaultPageListService(ICategoryService categoryService, ICmsConfiguration configuration,
            ILanguageService languageService, IAccessControlService accessControlService, ILayoutService layoutService,
            IUnitOfWork unitOfWork)
        {
            this.configuration = configuration;
            this.categoryService = categoryService;
            this.languageService = languageService;
            this.accessControlService = accessControlService;
            this.layoutService = layoutService;
            this.unitOfWork = unitOfWork;
        }

        public PagesGridViewModel<SiteSettingPageViewModel> GetFilteredPagesList(PagesFilter request)
        {
            request.SetDefaultSortingOptions("CreatedOn", true);

            PageProperties alias = null;
            PagesView viewAlias = null;
            PageProperties modelAlias = null;

            var query = unitOfWork.Session
                .QueryOver(() => viewAlias)
                .Inner.JoinAlias(() => viewAlias.Page, () => alias)
                .Where(() => !alias.IsDeleted && alias.Status != PageStatus.Preview);

            var hasnotSeoDisjunction =
                Restrictions.Disjunction()
                    .Add(Restrictions.Eq(Projections.Property(() => viewAlias.IsInSitemap), false))
                    .Add(RestrictionsExtensions.IsNullOrWhiteSpace(Projections.Property(() => alias.MetaTitle)))
                    .Add(RestrictionsExtensions.IsNullOrWhiteSpace(Projections.Property(() => alias.MetaKeywords)))
                    .Add(RestrictionsExtensions.IsNullOrWhiteSpace(Projections.Property(() => alias.MetaDescription)));

            var hasSeoProjection = Projections.Conditional(hasnotSeoDisjunction,
                Projections.Constant(false, NHibernateUtil.Boolean),
                Projections.Constant(true, NHibernateUtil.Boolean));

            query = FilterQuery(query, request, hasnotSeoDisjunction);

            query = query
                .SelectList(select => select
                    .Select(() => alias.Id).WithAlias(() => modelAlias.Id)
                    .Select(() => alias.Version).WithAlias(() => modelAlias.Version)
                    .Select(() => alias.Title).WithAlias(() => modelAlias.Title)
                    .Select(() => alias.Status).WithAlias(() => modelAlias.Status)
//                    .Select(hasSeoProjection).WithAlias(() => modelAlias.HasSEO)
                    .Select(() => alias.CreatedOn).WithAlias(() => modelAlias.CreatedOn)
                    .Select(() => alias.ModifiedOn).WithAlias(() => modelAlias.ModifiedOn)
                    .Select(() => alias.PageUrl).WithAlias(() => modelAlias.PageUrl)
                    .Select(() => alias.Language).WithAlias(() => modelAlias.Language)
                    .Select(() => alias.IsMasterPage).WithAlias(() => modelAlias.IsMasterPage))
                .TransformUsing(Transformers.AliasToBean<PageProperties>());

            if (configuration.Security.AccessControlEnabled)
            {
                IEnumerable<Guid> deniedPages = accessControlService.GetDeniedObjects<PageProperties>();
                foreach (var deniedPageId in deniedPages)
                {
                    var id = deniedPageId;
                    query = query.Where(f => f.Id != id);
                }
            }

            var count = query.ToRowCountFutureValue();

            IEnumerable<LookupKeyValue> languagesFuture = configuration.EnableMultilanguage ? languageService.GetLanguagesLookupValues() : null;

            var pages = query.AddSortingAndPaging(request).Future<PageProperties>();

            var layouts = layoutService
                        .GetAvailableLayouts()
                        .Select(l => new LookupKeyValue(
                            string.Format("{0}-{1}", l.IsMasterPage ? "m" : "l", l.TemplateId),
                            l.Title))
                        .ToList();

            var categoriesLookupList = categoryService.GetCategoriesLookupList(PageProperties.CategorizableItemKeyForPages);
            var model = CreateModel(pages, request, count, layouts, categoriesLookupList);

            if (languagesFuture != null)
            {
                model.Languages = languagesFuture.ToList();
                model.Languages.Insert(0, languageService.GetInvariantLanguageModel());
            }

            return model;
        }

        protected virtual PagesGridViewModel<SiteSettingPageViewModel> CreateModel(IEnumerable<PageProperties> pages,
            PagesFilter request, IFutureValue<int> count, IList<LookupKeyValue> layouts, IList<CategoryLookupModel> categoriesLookupList)
        {
            var pagesList = new List<SiteSettingPageViewModel>();
            foreach (var page in pages)
            {
                var model = new SiteSettingPageViewModel();
                model.Id = page.Id;
                model.Version = page.Version;
                model.Title = page.Title;
                model.PageStatus = page.Status;
                model.CreatedOn = page.CreatedOn.ToFormattedDateString();
                model.ModifiedOn = page.ModifiedOn.ToFormattedDateString();
                model.PageUrl = page.PageUrl;
                model.IsMasterPage = page.IsMasterPage;
                model.LanguageId = page.Language != null ? page.Language.Id : Guid.Empty;
                pagesList.Add(model);
            }
            return new PagesGridViewModel<SiteSettingPageViewModel>(
                pagesList,
                request,
                count.Value) { Layouts = layouts, CategoriesLookupList = categoriesLookupList};
        }

        protected virtual IQueryOver<PagesView, PagesView> FilterQuery(IQueryOver<PagesView, PagesView> query,
            PagesFilter request, Junction hasnotSeoDisjunction)
        {
            PageProperties alias = null;

            if (!request.IncludeArchived)
            {
                query = query.Where(() => !alias.IsArchived);
            }

            if (request.OnlyMasterPages)
            {
                query = query.Where(() => alias.IsMasterPage);
            }
            else if (!request.IncludeMasterPages)
            {
                query = query.Where(() => !alias.IsMasterPage);
            }

            if (!string.IsNullOrWhiteSpace(request.SearchQuery))
            {
                var searchQuery = string.Format("%{0}%", request.SearchQuery);
                query = query.Where(Restrictions.Disjunction()
                                        .Add(Restrictions.InsensitiveLike(Projections.Property(() => alias.Title), searchQuery))
                                        .Add(Restrictions.InsensitiveLike(Projections.Property(() => alias.PageUrl), searchQuery))
                                        .Add(Restrictions.InsensitiveLike(Projections.Property(() => alias.MetaTitle), searchQuery))
                                        .Add(Restrictions.InsensitiveLike(Projections.Property(() => alias.MetaDescription), searchQuery))
                                        .Add(Restrictions.InsensitiveLike(Projections.Property(() => alias.MetaKeywords), searchQuery)));
            }

            if (request.LanguageId.HasValue)
            {
                if (request.LanguageId.Value.HasDefaultValue())
                {
                    query = query.Where(Restrictions.IsNull(Projections.Property(() => alias.Language.Id)));
                }
                else
                {
                    query = query.Where(Restrictions.Eq(Projections.Property(() => alias.Language.Id), request.LanguageId.Value));
                }
            }

            if (request.Tags != null)
            {
                foreach (var tagKeyValue in request.Tags)
                {
                    var id = tagKeyValue.Key.ToGuidOrDefault();
                    query = query.WithSubquery.WhereExists(QueryOver.Of<PageTag>().Where(tag => tag.Tag.Id == id && tag.Page.Id == alias.Id).Select(tag => 1));
                }
            }

            if (request.Categories != null)
            {
                var categories = request.Categories.Select(c => new Guid(c.Key)).Distinct().ToList();

                foreach (var category in categories)
                {
                    var childCategories = categoryService.GetChildCategoriesIds(category).ToArray();
                    query = query.WithSubquery.WhereExists(QueryOver.Of<PageCategory>().Where(cat => !cat.IsDeleted && cat.Page.Id == alias.Id).WhereRestrictionOn(cat => cat.Category.Id).IsIn(childCategories).Select(cat => 1));
                }
            }

            if (request.Status.HasValue)
            {
                if (request.Status.Value == PageStatusFilterType.OnlyPublished)
                {
                    query = query.Where(() => alias.Status == PageStatus.Published);
                }
                else if (request.Status.Value == PageStatusFilterType.OnlyUnpublished)
                {
                    query = query.Where(() => alias.Status != PageStatus.Published);
                }
                else if (request.Status.Value == PageStatusFilterType.ContainingUnpublishedContents)
                {
                    PageContent pageContentAlias = null;
                    Root.Models.Content contentAlias = null;
                    Root.Models.Content contentHistoryAlias = null;
                    var subQuery = QueryOver.Of(() => pageContentAlias)
                        .Inner.JoinAlias(() => pageContentAlias.Content, () => contentAlias, () => !contentAlias.IsDeleted)
                        .Left.JoinAlias(() => contentAlias.History, () => contentHistoryAlias, () => !contentHistoryAlias.IsDeleted)
                        .Where(() => pageContentAlias.Page.Id == alias.Id && !pageContentAlias.IsDeleted)
                        .Where(() => contentHistoryAlias.Status == ContentStatus.Draft || contentAlias.Status == ContentStatus.Draft)
                        .Select(p => 1);

                    query = query.WithSubquery.WhereExists(subQuery);
                }
            }

            if (request.SeoStatus.HasValue)
            {
                if (request.SeoStatus.Value == SeoStatusFilterType.HasNotSeo)
                {
                    query = query.Where(hasnotSeoDisjunction);
                }
                else
                {
                    query = query.Where(Restrictions.Not(hasnotSeoDisjunction));
                }
            }

            if (!string.IsNullOrWhiteSpace(request.Layout))
            {
                Guid id;
                var length = request.Layout.Length - 2;
                if (request.Layout.StartsWith("m-") && Guid.TryParse(request.Layout.Substring(2, length), out id))
                {
                    query = query.Where(() => alias.MasterPage.Id == id);
                }

                if (request.Layout.StartsWith("l-") && Guid.TryParse(request.Layout.Substring(2, length), out id))
                {
                    query = query.Where(() => alias.Layout.Id == id);
                }
            }

            if (request.ContentId.HasValue)
            {
                Root.Models.Content contentAlias = null;
                ChildContent childContentAlias = null;
                HtmlContent htmlContentAlias = null;
                PageContent pageContentAlias = null;

                var htmlChildContentSubQuery =
                    QueryOver.Of(() => htmlContentAlias)
                        .JoinAlias(h => h.ChildContents, () => childContentAlias)
                        .Where(() => htmlContentAlias.Id == contentAlias.Id)
                        .And(() => childContentAlias.Child.Id == request.ContentId.Value)
                        .Select(pageContent => 1);

                var pageContentSubQuery = QueryOver.Of(() => pageContentAlias)
                    .JoinAlias(() => pageContentAlias.Content, () => contentAlias)
                    .And(() => pageContentAlias.Page.Id == alias.Id)
                    .And(() => !contentAlias.IsDeleted)
                    .And(() => !pageContentAlias.IsDeleted)
                    .And(Restrictions.Or(
                        Restrictions.Where(() => contentAlias.Id == request.ContentId.Value),
                        Subqueries.WhereExists(htmlChildContentSubQuery)
                    ))
                    .Select(pageContent => 1);

                query = query.WithSubquery.WhereExists(pageContentSubQuery);
            }

            return query;
        }
    }
}