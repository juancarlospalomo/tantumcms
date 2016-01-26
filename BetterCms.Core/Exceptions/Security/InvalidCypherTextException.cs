﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvalidCypherTextException.cs" company="Devbridge Group LLC">
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

namespace BetterCms.Core.Exceptions.Security
{    
    /// <summary>
    /// Represents errors that occur when a text can't be decoded or the text is tampered 
    /// </summary>
    [Serializable]
    public class InvalidCypherTextException : CmsException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCypherTextException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public InvalidCypherTextException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCypherTextException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public InvalidCypherTextException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
