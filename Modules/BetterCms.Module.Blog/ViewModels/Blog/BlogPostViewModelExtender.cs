﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogPostViewModelExtender.cs" company="Devbridge Group LLC">
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

using BetterCms.Core.Security;

namespace BetterCms.Module.Blog.ViewModels.Blog
{
    public class BlogPostViewModelExtender : BlogPostViewModel
    {
        /// <summary>
        /// Gets or sets the page content identifier.
        /// </summary>
        /// <value>
        /// The page content identifier.
        /// </value>
        public System.Guid? PageContentId { get; set; }

        /// <summary>
        /// Gets or sets the region identifier.
        /// </summary>
        /// <value>
        /// The region identifier.
        /// </value>
        public System.Guid? RegionId { get; set; }

        /// <summary>
        /// Gets or sets the page published date.
        /// </summary>
        /// <value>
        /// The page published date.
        /// </value>
        public System.DateTime? PublishedOn { get; set; }

        /// <summary>
        /// Gets or sets the page layout id.
        /// </summary>
        /// <value>
        /// The page layout id.
        /// </value>
        public System.Guid? LayoutId { get; set; }

        /// <summary>
        /// Gets or sets the master page id.
        /// </summary>
        /// <value>
        /// The master page id.
        /// </value>
        public System.Guid? MasterPageId { get; set; }

        /// <summary>
        /// Gets or sets the featured image id.
        /// </summary>
        /// <value>
        /// The featured image id.
        /// </value>
        public System.Guid? FeaturedImageId { get; set; }

        /// <summary>
        /// Gets or sets the secondary image id.
        /// </summary>
        /// <value>
        /// The secondary image id.
        /// </value>
        public System.Guid? SecondaryImageId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether blog post is marked as archived.
        /// </summary>
        /// <value>
        /// <c>true</c> if blog post is marked as archived; otherwise, <c>false</c>.
        /// </value>
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use no follow.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to use no follow; otherwise, <c>false</c>.
        /// </value>
        public bool UseNoFollow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use no index.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to use no index; otherwise, <c>false</c>.
        /// </value>
        public bool UseNoIndex { get; set; }

        /// <summary>
        /// Gets or sets the page meta keywords.
        /// </summary>
        /// <value>
        /// The page meta keywords.
        /// </value>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets the page meta description.
        /// </summary>
        /// <value>
        /// The page meta description.
        /// </value>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the access rules.
        /// </summary>
        /// <value>
        /// The access rules.
        /// </value>
        public System.Collections.Generic.IList<IAccessRule> AccessRules { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to update language.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to update language; otherwise, <c>false</c>.
        /// </value>
        public bool UpdateLanguage { get; set; }

        /// <summary>
        /// Gets or sets the language group identifier.
        /// </summary>
        /// <value>
        /// The language group identifier.
        /// </value>
        public Guid? LanguageGroupIdentifier { get; set; }
    }
}