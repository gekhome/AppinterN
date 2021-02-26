using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class TeacherService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public TeacherService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(TeachersViewModel model)
        {
            Teachers entity = new Teachers()
            {
                MemberID = model.MemberID,
                TaxNumber = model.TaxNumber,
                FullName = model.FullName,
                Country = model.Country,
                School = model.School,
                SchoolAddress = model.SchoolAddress,
                Phone = model.Phone,
                Email = model.Email,
                SocialMedia = model.SocialMedia,
                LoginName = model.LoginName
            };
            entities.Teachers.Add(entity);
            entities.SaveChanges();
        }

        public void Update(TeachersViewModel model)
        {
            var entity = new Teachers();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.FullName = model.FullName;
            entity.Country = model.Country;
            entity.School = model.School;
            entity.SchoolAddress = model.SchoolAddress;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.SocialMedia = model.SocialMedia;
            entity.LoginName = model.LoginName;

            entities.Teachers.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}