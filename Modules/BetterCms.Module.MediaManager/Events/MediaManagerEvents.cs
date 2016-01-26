﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MediaManagerEvents.cs" company="Devbridge Group LLC">
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
using BetterCms.Module.MediaManager.Models;

using BetterModules.Events;

// ReSharper disable CheckNamespace
namespace BetterCms.Events
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Attachable page events container
    /// </summary>
    public class MediaManagerEvents : EventsBase<MediaManagerEvents>
    {
        /// <summary>
        /// Occurs when a media file is uploaded.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<MediaFile>> MediaFileUploaded;

        /// <summary>
        /// Occurs when a media file is updated.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<MediaFile>> MediaFileUpdated;

        /// <summary>
        /// Occurs when a media file is deleted.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<MediaFile>> MediaFileDeleted;

        /// <summary>
        /// Occurs when a media folder is created.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<MediaFolder>> MediaFolderCreated;

        /// <summary>
        /// Occurs when a media folder is updated.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<MediaFolder>> MediaFolderUpdated;

        /// <summary>
        /// Occurs when a media folder is deleted.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<MediaFolder>> MediaFolderDeleted;
        
        /// <summary>
        /// Occurs when a media is restored from archive.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<Media>> MediaRestored;
        
        /// <summary>
        /// Occurs when a media is archived.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<Media>> MediaArchived;
        
        /// <summary>
        /// Occurs when a media is restored.
        /// </summary>
        public event DefaultEventHandler<SingleItemEventArgs<Media>> MediaUnarchived;
        
        /// <summary>
        /// Called when a blog is created.
        /// </summary>
        public void OnMediaFileUploaded(MediaFile mediaFile)
        {
            if (MediaFileUploaded != null)
            {
                MediaFileUploaded(new SingleItemEventArgs<MediaFile>(mediaFile));
            }
        }

        public void OnMediaFileDeleted(MediaFile mediaFile)
        {
            if (MediaFileDeleted != null)
            {
                MediaFileDeleted(new SingleItemEventArgs<MediaFile>(mediaFile));
            }
        }

        public void OnMediaFileUpdated(MediaFile mediaFile)
        {
            if (MediaFileUpdated != null)
            {
                MediaFileUpdated(new SingleItemEventArgs<MediaFile>(mediaFile));
            }
        }

        public void OnMediaFolderCreated(MediaFolder mediaFolder)
        {
            if (MediaFolderCreated != null)
            {
                MediaFolderCreated(new SingleItemEventArgs<MediaFolder>(mediaFolder));
            }
        }

        public void OnMediaFolderUpdated(MediaFolder mediaFolder)
        {
            if (MediaFolderUpdated != null)
            {
                MediaFolderUpdated(new SingleItemEventArgs<MediaFolder>(mediaFolder));
            }
        }

        public void OnMediaFolderDeleted(MediaFolder mediaFolder)
        {
            if (MediaFolderDeleted != null)
            {
                MediaFolderDeleted(new SingleItemEventArgs<MediaFolder>(mediaFolder));
            }
        }
        
        public void OnMediaRestored(Media media)
        {
            if (MediaRestored != null)
            {
                MediaRestored(new SingleItemEventArgs<Media>(media));
            }
        }
        
        public void OnMediaArchived(Media media)
        {
            if (MediaArchived != null)
            {
                MediaArchived(new SingleItemEventArgs<Media>(media));
            }
        }
        
        public void OnMediaUnarchived(Media media)
        {
            if (MediaUnarchived != null)
            {
                MediaUnarchived(new SingleItemEventArgs<Media>(media));
            }
        }
    }
}
