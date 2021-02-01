using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class AmbassadorService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public AmbassadorService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(AmbassadorsViewModel model)
        {
            Ambassadors entity = new Ambassadors()
            {
                MemberID = model.MemberID,
                LoginName = model.LoginName,
                Email = model.Email,
                FullName = model.FullName,
                Gender = model.Gender,
                Address = model.Address,
                City = model.City,
                State = model.State,
                Zip = model.Zip,
                Country = model.Country,
                Phone = model.Phone,
                Fax = model.Fax,
                JobSector = model.JobSector,
                WorkingYears = model.WorkingYears,
                Employer = model.Employer
            };
            entities.Ambassadors.Add(entity);
            entities.SaveChanges();

        }

        public void Update(AmbassadorsViewModel model)
        {
            var entity = new Ambassadors();

            entity.MemberID = model.MemberID;
            entity.LoginName = model.LoginName;
            entity.Email = model.Email;
            entity.FullName = model.FullName;
            entity.Gender = model.Gender;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.State = model.State;
            entity.Country = model.Country;
            entity.Zip = model.Zip;
            entity.Phone = model.Phone;
            entity.Fax = model.Fax;
            entity.JobSector = model.JobSector;
            entity.WorkingYears = model.WorkingYears;
            entity.Employer = model.Employer;

            entities.Ambassadors.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }


        public void Dispose()
        {
            entities.Dispose();
        }

    }
}