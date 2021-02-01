using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appintern.Core.Models
{
    public class ServiceItemModel
    {
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string IconClass { get; set; }

        public ServiceItemModel(string title, string introduction, string iconClass)
        {
            Title = title;
            Introduction = introduction;
            IconClass = iconClass;
        }

    }

    public class ServicesModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public List<ServiceItemModel> Services { get; set; }

        public bool HasServices => Services != null && Services.Count > 0;

        public ServicesModel(string title, string subtitle, List<ServiceItemModel> services)
        {
            Title = title;
            Subtitle = subtitle;
            Services = services;
        }
    }
}
