using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Appintern.Web.DAL;
using Appintern.Web.ViewModels;

namespace Appintern.Web.DAL.Services
{
    public class ArticleService :   IDisposable
    {
        private readonly AppinternWorksEntities entities;

        public ArticleService(AppinternWorksEntities entities)
        {
            this.entities = entities;
        }

        public void Create(ArticleViewModel model)
        {
            Articles entity = new Articles()
            {
                ArticleId = model.ArticleId,
                ArticleDate = model.ArticleDate,
                AuthorName = model.AuthorName,
                Title = model.Title,
                Description = model.Description,
                Country = model.Country,
                ArticleMemberID = model.ArticleMemberId
            };
            entities.Articles.Add(entity);
            entities.SaveChanges();
        }

        public void Update(ArticleViewModel model)
        {
            var entity = new Articles();

            entity.ArticleId = model.ArticleId;
            entity.ArticleDate = model.ArticleDate;
            entity.AuthorName = model.AuthorName;
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.Country = model.Country;
            entity.ArticleMemberID = model.ArticleMemberId;

            entities.Articles.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}