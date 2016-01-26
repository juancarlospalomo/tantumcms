﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogPost.cs" company="Devbridge Group LLC">
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

using BetterCms.Core.DataContracts;
using BetterCms.Module.Pages.Models;

namespace BetterCms.Module.Blog.Models
{
    [Serializable]
    public class BlogPost : PageProperties, ICategorized
    {
        public const string CategorizableItemKeyForBlogs = "Blog Posts";

        public virtual Author Author { get; set; }

        public virtual DateTime ActivationDate { get; set; }

        public virtual DateTime? ExpirationDate { get; set; }

        public override string GetCategorizableItemKey()
        {
            return CategorizableItemKeyForBlogs;
        }

        public override PageProperties Duplicate()
        {
            return CopyDataToDuplicate(new BlogPost());
        }

        protected override PageProperties CopyDataToDuplicate(PageProperties duplicate)
        {
            var blogPost = (BlogPost)base.CopyDataToDuplicate(duplicate);

            blogPost.Author = Author;
            blogPost.ActivationDate = ActivationDate;
            blogPost.ExpirationDate = ExpirationDate;

            return blogPost;
        }
    }
}