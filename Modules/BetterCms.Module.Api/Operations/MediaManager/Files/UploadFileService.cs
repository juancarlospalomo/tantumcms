﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UploadFileService.cs" company="Devbridge Group LLC">
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
using System.ComponentModel;
using System.IO;
using System.Linq;

using BetterModules.Core.DataAccess;
using BetterModules.Core.DataAccess.DataContext;
using BetterCms.Core.Exceptions.Api;
using BetterCms.Core.Security;
using BetterCms.Module.Api.Operations.MediaManager.Files.File;
using BetterCms.Module.MediaManager.Models;
using BetterCms.Module.MediaManager.Models.Extensions;
using BetterCms.Module.MediaManager.Services;
using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.Models.Extensions;

namespace BetterCms.Module.Api.Operations.MediaManager.Files
{
    /// <summary>
    /// The upload file service.
    /// </summary>
    public class UploadFileService: IUploadFileService
    {
        private readonly IRepository repository;

        private readonly IMediaFileService mediaFileService;

        private readonly IAccessControlService accessControlService;

        private readonly ICmsConfiguration configuration;

        public UploadFileService(IRepository repository, IMediaFileService mediaFileService, IAccessControlService accessControlService, ICmsConfiguration configuration)
        {
            this.repository = repository;
            this.mediaFileService = mediaFileService;
            this.accessControlService = accessControlService;
            this.configuration = configuration;
        }

        /// <summary>
        /// Upload file from the stream.
        /// </summary>
        /// <param name="request">The upload file request.</param>
        /// <returns>The upload file response.</returns>
        public UploadFileResponse Post(UploadFileRequest request)
        {
            MediaFolder parentFolder = null;
            if (request.Data.FolderId.HasValue)
            {
                parentFolder = repository.AsQueryable<MediaFolder>()
                    .Where(c => c.Id == request.Data.FolderId.Value && !c.IsDeleted)
                    .FirstOne();

                if (parentFolder.Type != Module.MediaManager.Models.MediaType.File)
                {
                    throw new CmsApiValidationException("Folder must be type of an file.");
                }
            }

            var maxLength = configuration.Storage.MaximumFileNameLength > 0 ? configuration.Storage.MaximumFileNameLength : 100;
            // Fix for IIS express + IE (if full path is returned)
            var fileName = Path.GetFileName(request.Data.FileName);
            if (fileName.Length > maxLength)
            {
                fileName = string.Concat(Path.GetFileNameWithoutExtension(fileName.Substring(0, maxLength)), Path.GetExtension(fileName));
            }

            var savedFile = mediaFileService.UploadFileWithStream(
                Module.MediaManager.Models.MediaType.File,
                parentFolder != null ? parentFolder.Id : Guid.Empty,
                fileName,
                request.Data.FileStream.Length,
                request.Data.FileStream,
                request.Data.WaitForUploadResult,
                request.Data.Title,
                request.Data.Description);

            if (savedFile != null)
            {
                if (request.Data.AccessRules != null)
                {
                    if (savedFile.AccessRules != null)
                    {
                        savedFile.AccessRules.RemoveDuplicateEntities();
                    }
                    var accessRules =
                        request.Data.AccessRules.Select(
                            r => (IAccessRule)new AccessRule { AccessLevel = (AccessLevel)(int)r.AccessLevel, Identity = r.Identity, IsForRole = r.IsForRole })
                            .ToList();
                    accessControlService.UpdateAccessControl(savedFile, accessRules);
                    mediaFileService.SaveMediaFile(savedFile);
                }

                Events.MediaManagerEvents.Instance.OnMediaFileUploaded(savedFile);
            }

            return new UploadFileResponse
            {
                Data = savedFile.Id
            };
        }

        /// <summary>
        /// Reupload file from the stream.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public ReuploadFileResponse Put(ReuploadFileRequest request)
        {
            if (request.Data.Id.Equals(Guid.Empty))
            {
                throw new CmsApiValidationException("MediaFile ID must be provided");
            }

//            var file = repository.AsQueryable<MediaFile>().FirstOrDefault(f => f.Id == request.Data.Id);
//            if (file == null)
//            {
//                throw new CmsApiValidationException("File with specified ID could not be found");
//            }
            // Create and save history item
//            mediaFileService.SaveMediaFile((MediaFile)file.CreateHistoryItem());

            var savedFile = mediaFileService.UploadFileWithStream(
                Module.MediaManager.Models.MediaType.File,
                Guid.Empty,
                request.Data.FileName,
                request.Data.FileStream.Length,
                request.Data.FileStream,
                request.Data.WaitForUploadResult,
                string.Empty,
                string.Empty,
                request.Data.Id);

//            mediaFileService.SaveMediaFile(savedFile);
            return new ReuploadFileResponse { Data = savedFile.Id };
        }
    }
}