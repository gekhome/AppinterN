using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class ApprenticeshipService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public ApprenticeshipService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(ApprenticeshipViewModel model)
        {
            Apprenticeships entity = new Apprenticeships()
            {
                ApprenticeshipID = model.ApprenticeshipID,
                PostDate = model.PostDate,
                DurationMonths = model.DurationMonths,
                Name = model.Name,
                Title = model.Title,
                Description = model.Description,
                Country = model.Country,
                Commitment = model.Commitment,
                Compensation = model.Compensation,
                Requirements = model.Requirements,
                JobSector = model.JobSector,
                EmployerID = model.EmployerID
            };
            entities.Apprenticeships.Add(entity);
            entities.SaveChanges();
        }

        public void Update(ApprenticeshipViewModel model)
        {
            var entity = new Apprenticeships();

            entity.ApprenticeshipID = model.ApprenticeshipID;
            entity.PostDate = model.PostDate;
            entity.DurationMonths = model.DurationMonths;
            entity.Name = model.Name;
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.Country = model.Country;
            entity.Commitment = model.Commitment;
            entity.Compensation = model.Compensation;
            entity.Requirements = model.Requirements;
            entity.JobSector = model.JobSector;
            entity.EmployerID = model.EmployerID;

            entities.Apprenticeships.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}