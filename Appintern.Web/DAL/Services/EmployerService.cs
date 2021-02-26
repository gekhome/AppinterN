using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class EmployerService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public EmployerService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(EmployersViewModel model)
        {
            Employers entity = new Employers()
            {
                MemberID = model.MemberID,
                TaxNumber = model.TaxNumber,
                CompanyName = model.CompanyName,
                ContactPerson = model.ContactPerson,
                Headquarters = model.Headquarters,
                Country = model.Country,
                JobSector1 = model.JobSector1,
                JobSector2 = model.JobSector2,
                JobSector3 = model.JobSector3,
                Phone = model.Phone,
                Email = model.Email,
                Website = model.Website,
                SocialMedia = model.SocialMedia,
                LoginName = model.LoginName

            };
            entities.Employers.Add(entity);
            entities.SaveChanges();
        }

        public void Update(EmployersViewModel model)
        {
            var entity = new Employers();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.CompanyName = model.CompanyName;
            entity.ContactPerson = model.ContactPerson;
            entity.Headquarters = model.Headquarters;
            entity.Country = model.Country;
            entity.JobSector1 = model.JobSector1;
            entity.JobSector2 = model.JobSector2;
            entity.JobSector3 = model.JobSector3;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Website = model.Website;
            entity.SocialMedia = model.SocialMedia;
            entity.LoginName = model.LoginName;

            entities.Employers.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}