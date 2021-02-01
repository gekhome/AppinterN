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
                LoginName = model.LoginName,
                Email = model.Email,
                SchoolName = model.SchoolName,
                ContactPerson = model.ContactPerson,
                Address = model.Address,
                City = model.City,
                State = model.State,
                Zip = model.Zip,
                Country = model.Country,
                Phone = model.Phone,
                Fax = model.Fax
            };
            entities.Schools.Add(entity);
            entities.SaveChanges();
        }

        public void Update(SchoolsViewModel model)
        {
            var entity = new Schools();

            entity.MemberID = model.MemberID;
            entity.LoginName = model.LoginName;
            entity.Email = model.Email;
            entity.SchoolName = model.SchoolName;
            entity.ContactPerson = model.ContactPerson;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.State = model.State;
            entity.Country = model.Country;
            entity.Zip = model.Zip;
            entity.Phone = model.Phone;
            entity.Fax = model.Fax;

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