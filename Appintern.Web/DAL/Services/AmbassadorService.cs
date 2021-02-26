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
                TaxNumber = model.TaxNumber,
                LoginName = model.LoginName,
                FullName = model.FullName,
                Address = model.Address,
                Country = model.Country,
                Phone = model.Phone,
                Email = model.Email,
                Website = model.Website,
                SocialMedia = model.SocialMedia,
                Occupation = model.Occupation,
                JobSector = model.JobSector,
                Employer = model.Employer
            };
            entities.Ambassadors.Add(entity);
            entities.SaveChanges();

        }

        public void Update(AmbassadorsViewModel model)
        {
            var entity = new Ambassadors();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.LoginName = model.LoginName;
            entity.FullName = model.FullName;
            entity.Address = model.Address;
            entity.Country = model.Country;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Website = model.Website;
            entity.SocialMedia = model.SocialMedia;
            entity.Occupation = model.Occupation;
            entity.JobSector = model.JobSector;
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