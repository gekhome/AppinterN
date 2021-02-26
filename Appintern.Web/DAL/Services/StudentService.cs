using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class StudentService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public StudentService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(StudentsViewModel model)
        {
            Students entity = new Students()
            {
                MemberID = model.MemberID,
                TaxNumber = model.TaxNumber,
                FullName = model.FullName,
                Birthdate = model.Birthdate,
                Gender = model.Gender,
                Phone = model.Phone,
                Email = model.Email,
                Country = model.Country,
                Specialization = model.Specialization,
                School = model.School,
                LoginName = model.LoginName
            };
            entities.Students.Add(entity);
            entities.SaveChanges();
        }

        public void Update(StudentsViewModel model)
        {
            var entity = new Students();

            entity.MemberID = model.MemberID;
            entity.TaxNumber = model.TaxNumber;
            entity.FullName = model.FullName;
            entity.Birthdate = model.Birthdate;
            entity.Gender = model.Gender;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Country = model.Country;
            entity.Specialization = model.Specialization;
            entity.School = model.School;
            entity.LoginName = model.LoginName;

            entities.Students.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}