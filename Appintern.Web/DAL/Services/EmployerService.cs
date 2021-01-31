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
                LoginName = model.LoginName,
                Email = model.Email,
                TradeName = model.TradeName,
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
            entities.Employers.Add(entity);
            entities.SaveChanges();
        }

        public void Update(EmployersViewModel model)
        {
            var entity = new Employers();

            entity.MemberID = model.MemberID;
            entity.LoginName = model.LoginName;
            entity.Email = model.Email;
            entity.TradeName = model.TradeName;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.State = model.State;
            entity.Country = model.Country;
            entity.Zip = model.Zip;
            entity.Phone = model.Phone;
            entity.Fax = model.Fax;
            entity.JobSector = model.JobSector;
            entity.ContactPerson = model.ContactPerson;

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