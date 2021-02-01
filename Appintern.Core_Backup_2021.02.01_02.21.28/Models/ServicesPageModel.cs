using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Models;

namespace Appintern.Core.Models
{
    // Left side of Services Page contents
    public class ServicesMainItemModel
    {
        public string Header { get; set; }
        public string Introduction { get; set; }
        public string Link { get; set; }
        public string IconClass { get; set; }

        public ServicesMainItemModel(string header, string introduction, string link, string iconClass)
        {
            Header = header;
            Introduction = introduction;
            Link = link;
            IconClass = iconClass;
        }
    }

    public class ServicesMainModel
    {
        public List<ServicesMainItemModel> ServicesItems { get; set; }

        public bool HasServicesItems => ServicesItems != null && ServicesItems.Count > 0;

        public ServicesMainModel(List<ServicesMainItemModel> items)
        {
            ServicesItems = items;
        }
    }

    // Right sidebar of Services Page contents
    public class ServicesSidebarItemModel
    {
        public string Text { get; set; }

        public string Link { get; set; }

        public ServicesSidebarItemModel(string text, string link)
        {
            Text = text;
            Link = link;
        }
    }

    public class ServicesSidebarModel
    {
        public string SidebarTitle { get; set; }

        public List<ServicesSidebarItemModel> SidebarItems { get; set; }

        public bool HasSidebarItems => SidebarItems != null && SidebarItems.Count > 0;

        public ServicesSidebarModel(string sidebarTitle, List<ServicesSidebarItemModel> sidebarItems)
        {
            SidebarTitle = sidebarTitle;
            SidebarItems = sidebarItems;
        }
    }
}
