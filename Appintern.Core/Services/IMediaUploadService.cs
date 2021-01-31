using System;
using System.Web;
using Umbraco.Core.Models;

namespace Appintern.Core.Services
{
    public interface IMediaUploadService
    {
        string CreateMediaItemFromFileUpload(HttpPostedFileBase file, int parentId, string mediaTypeAlias, int userId = -1);

        string CreateMediaItemFromFileUpload(HttpPostedFileBase file, Guid parentId, string mediaTypeAlias, int userId = -1);

        string CreateMediaItemFromFileUpload(HttpPostedFileBase file, IMedia parent, string mediaTypeAlias, int userId = -1);

        string SetMediaItemValueFromFileUpload(HttpPostedFileBase file, IMedia mediaItem);
    }
}
