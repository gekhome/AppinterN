﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppinternWorksEntities : DbContext
    {
        public AppinternWorksEntities()
            : base("name=AppinternWorksEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Commitments> Commitments { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Durations> Durations { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<JobSectors> JobSectors { get; set; }
        public virtual DbSet<MemberGroups> MemberGroups { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Ambassadors> Ambassadors { get; set; }
        public virtual DbSet<Graduates> Graduates { get; set; }
        public virtual DbSet<LiaisonOfficers> LiaisonOfficers { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Apprenticeships> Apprenticeships { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<rep_MembersApprenticeships> rep_MembersApprenticeships { get; set; }
        public virtual DbSet<rep_MembersArticles> rep_MembersArticles { get; set; }
        public virtual DbSet<sql_MembersAll> sql_MembersAll { get; set; }
    }
}
