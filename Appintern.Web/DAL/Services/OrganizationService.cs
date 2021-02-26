using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class OrganizationService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public OrganizationService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(OrganizationsViewModel model)
        {
            Organizations entity = new Organizations()
            {
                MemberID = model.MemberID,
                TaxNumber = model.TaxNumber,
                OrganizationName = model.OrganizationName,
                ContactPerson = model.ContactPerson,
                Country = model.Country,
                Headquarters = model.Headquarters,
                JobSector = model.JobSector,
                Phone = model.Phone,
                Email = model.Email,
                Website = model.Website,
                SocialMedia = model.SocialMedia,
                LoginName = model.LoginName
            };
            entities.Organizations.Add(entity);
            entities.SaveChanges();
        }

        public void Update(OrganizationsViewModel model)
        {
            var entity = new Organizations();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.OrganizationName = model.OrganizationName;
            entity.ContactPerson = model.ContactPerson;
            entity.Country = model.Country;
            entity.Headquarters = model.Headquarters;
            entity.JobSector = model.JobSector;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Website = model.Website;
            entity.SocialMedia = model.SocialMedia;
            entity.LoginName = model.LoginName;

            entities.Organizations.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}