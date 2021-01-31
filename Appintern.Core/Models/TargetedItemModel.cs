using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appintern.Core.Models
{
    public class TargetedItemModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }

        public TargetedItemModel(string name, string description, string imageUrl, string linkUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            LinkUrl = linkUrl;
        }

    }
}
