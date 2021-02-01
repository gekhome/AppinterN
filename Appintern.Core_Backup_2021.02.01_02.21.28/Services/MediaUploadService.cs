using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace Appintern.Core.Services
{
    public class MediaUploadService : IMediaUploadService
    {
        private readonly IMediaService _mediaService;
        private readonly IContentTypeBaseServiceProvider _contentTypeBaseServiceProvider;

        public MediaUploadService(IMediaService mediaService,
            IContentTypeBaseServiceProvider contentTypeBaseServiceProvider)
        {
            _mediaService = mediaService;
            _contentTypeBaseServiceProvider = contentTypeBaseServiceProvider;
        }

        /// <summary>
        /// You pass in a file and it uploads it to the media section and returns the udi for the media item
        /// </summary>
        /// <param name="file">The file to upload</param>
        /// <param name="parentId">The id of the parent media item</param>
        /// <param name="mediaTypeAlias">The media type alias, e.g. Image, File, Folder</param>
        /// <returns>The udi for the new media item</returns>
        public string CreateMediaItemFromFileUpload(HttpPostedFileBase file, int parentId, string mediaTypeAlias, int userId = -1)
        {
            var mediaItem = _mediaService.CreateMedia(file.FileName, parentId, mediaTypeAlias);
            return SetMediaItemValueFromFileUpload(file, mediaItem);
        }

        /// <summary>
        /// You pass in a file and it uploads it to the media section and returns the udi for the media item
        /// </summary>
        /// <param name="file">The file to upload</param>
        /// <param name="parentId">The id of the parent media item to upload it to</param>
        /// <param name="mediaTypeAlias">The media type alias, e.g. Image, File, Folder</param>
        /// <returns>The udi for the new media item</returns>
        public string CreateMediaItemFromFileUpload(HttpPostedFileBase file, Guid parentId, string mediaTypeAlias, int userId = -1)
        {
            var mediaItem = _mediaService.CreateMedia(file.FileName, parentId, mediaTypeAlias);
            return SetMediaItemValueFromFileUpload(file, mediaItem);
        }

        /// <summary>
        /// You pass in a file and it uploads it to the media section and returns the udi for the media item
        /// </summary>
        /// <param name="file">The file to upload</param>
        /// <param name="parent">The parent media item</param>
        /// <param name="mediaTypeAlias">The media type alias, e.g. Image, File, Folder</param>
        /// <returns>The udi for the new media item</returns>
        public string CreateMediaItemFromFileUpload(HttpPostedFileBase file, IMedia parent, string mediaTypeAlias, int userId = -1)
        {
            var mediaItem = _mediaService.CreateMedia(file.FileName, parent, mediaTypeAlias);
            return SetMediaItemValueFromFileUpload(file, mediaItem);
        }

        /// <summary>
        /// You pass in a file and it uploads it to the media item
        /// </summary>
        /// <param name="file">The file to upload</param>
        /// <param name="mediaItem">The media item to upload the file to</param>
        /// <returns>The udi for the new media item</returns>
        public string SetMediaItemValueFromFileUpload(HttpPostedFileBase file, IMedia mediaItem)
        {
            mediaItem.SetValue(_contentTypeBaseServiceProvider, "umbracoFile", file.FileName, file.InputStream);

            _mediaService.Save(mediaItem);

            // Key is the Guid and N means fromat as 32 hex digits
            // Refer to this article: https://docs.microsoft.com/en-us/dotnet/api/system.guid.tostring?view=net-5.0
            var udi = $"umb://media/{mediaItem.Key:N}";
            return udi;
        }
    }
}
