using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Models;
using MvcPaging;

namespace Appintern.Web.ViewModels
{
    public class MemberListModel
    {
        [Display(Name = "Member Type")]
        public string MemberType { get; set; }

        public IEnumerable<SelectListItem> MemberTypes { get; set; }

        public IEnumerable<IMember> ListResults { get; set; }

        public IPagedList<MemberTypeProfile> ProfileResults { get; set; }

        public bool HasResults { get { return ListResults != null && ListResults.Count() > 0; } }

    }

    public class MemberTypeProfile
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Type { get; set; }

        public string UrlSlug { get; set; }

        public MemberTypeProfile(string name, string email, string type, string urlSlug)
        {
            Name = name;
            Email = email;
            Type = type;
            UrlSlug = urlSlug;
        }

    }

}