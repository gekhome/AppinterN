using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class SchoolService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public SchoolService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(SchoolsViewModel model)
        {
            Schools entity = new Schools()
            {
                MemberID = model.MemberID,
                TaxNumber = model.TaxNumber,
                SchoolName = model.SchoolName,
                ContactPerson = model.ContactPerson,
                Country = model.Country,
                Address = model.Address,
                Phone = model.Phone,
                Email = model.Email,
                Website = model.Website,
                SocialMedia = model.SocialMedia,
                LoginName = model.LoginName
            };
            entities.Schools.Add(entity);
            entities.SaveChanges();
        }

        public void Update(SchoolsViewModel model)
        {
            var entity = new Schools();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.SchoolName = model.SchoolName;
            entity.ContactPerson = model.ContactPerson;
            entity.Country = model.Country;
            entity.Address = model.Address;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Website = model.Website;
            entity.SocialMedia = model.SocialMedia;
            entity.LoginName = model.LoginName;

            entities.Schools.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}