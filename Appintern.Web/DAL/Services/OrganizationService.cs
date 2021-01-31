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
                LoginName = model.LoginName,
                Email = model.Email,
                OrganizationName = model.OrganizationName,
                Address = model.Address,
                City = model.City,
                State = model.State,
                Zip = model.Zip,
                Country = model.Country,
                Phone = model.Phone,
                Fax = model.Fax,
                JobSector = model.JobSector,
                ContactPerson = model.ContactPerson
            };
            entities.Organizations.Add(entity);
            entities.SaveChanges();
        }

        public void Update(OrganizationsViewModel model)
        {
            var entity = new Organizations();

            entity.MemberID = model.MemberID;
            entity.LoginName = model.LoginName;
            entity.Email = model.Email;
            entity.OrganizationName = model.OrganizationName;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.State = model.State;
            entity.Country = model.Country;
            entity.Zip = model.Zip;
            entity.Phone = model.Phone;
            entity.Fax = model.Fax;
            entity.JobSector = model.JobSector;
            entity.ContactPerson = model.ContactPerson;

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