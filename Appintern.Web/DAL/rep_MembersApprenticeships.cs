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
    
    public partial class rep_MembersApprenticeships
    {
        public int AppID { get; set; }
        public int MemberID { get; set; }
        public string TradeName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DurationMonths { get; set; }
        public string Commitment { get; set; }
        public string Compensation { get; set; }
        public string JobSector { get; set; }
        public string Country { get; set; }
    }
}
