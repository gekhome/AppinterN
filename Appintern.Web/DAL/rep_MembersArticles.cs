//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appintern.Web.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class rep_MembersArticles
    {
        public int ArticleId { get; set; }
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string LoginName { get; set; }
        public Nullable<System.DateTime> ArticleDate { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
