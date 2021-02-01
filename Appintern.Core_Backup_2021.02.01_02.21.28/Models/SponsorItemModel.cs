using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Models;

namespace Appintern.Core.Models
{
    public class SponsorItemModel
    {
        public string ImageUrl { get; set; }
        public Link LinkUrl { get; set; }

        public SponsorItemModel(string imageUrl, Link linkUrl)
        {
            ImageUrl = imageUrl;
            LinkUrl = linkUrl;
        }

    }
}
