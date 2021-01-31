﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class GraduateService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public GraduateService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(GraduatesViewModel model)
        {
            Graduates entity = new Graduates()
            {
                MemberID = model.MemberID,
                LoginName = model.LoginName,
                Email = model.Email,
                FullName = model.FullName,
                Gender = model.Gender,
                Birthdate = model.Birthdate,
                Address = model.Address,
                City = model.City,
                State = model.State,
                Zip = model.Zip,
                Country = model.Country,
                Phone = model.Phone,
                JobSector = model.JobSector,
                Specialty = model.Specialty,
                School = model.School
            };
            entities.Graduates.Add(entity);
            entities.SaveChanges();
        }

        public void Update(GraduatesViewModel model)
        {
            var entity = new Graduates();

            entity.MemberID = model.MemberID;
            entity.LoginName = model.LoginName;
            entity.Email = model.Email;
            entity.FullName = model.FullName;
            entity.Gender = model.Gender;
            entity.Birthdate = model.Birthdate;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.State = model.State;
            entity.Country = model.Country;
            entity.Zip = model.Zip;
            entity.Phone = model.Phone;
            entity.JobSector = model.JobSector;
            entity.Specialty = model.Specialty;
            entity.School = model.School;

            entities.Graduates.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}