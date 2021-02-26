using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class LiaisonOfficerService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public LiaisonOfficerService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(LiaisonOfficersViewModel model)
        {
            LiaisonOfficers entity = new LiaisonOfficers()
            {
                MemberID = model.MemberID,
                TaxNumber = model.TaxNumber,
                FullName = model.FullName,
                Country = model.Country,
                Phone = model.Phone,
                Email = model.Email,
                OfficeAddress = model.OfficeAddress,
                Occupation = model.Occupation,
                Employer = model.Employer,
                LoginName = model.LoginName
            };
            entities.LiaisonOfficers.Add(entity);
            entities.SaveChanges();
        }

        public void Update(LiaisonOfficersViewModel model)
        {
            var entity = new LiaisonOfficers();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.FullName = model.FullName;
            entity.Country = model.Country;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.OfficeAddress = model.OfficeAddress;
            entity.Occupation = model.Occupation;
            entity.Employer = model.Employer;
            entity.LoginName = model.LoginName;

            entities.LiaisonOfficers.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}