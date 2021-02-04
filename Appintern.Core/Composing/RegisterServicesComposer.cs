using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Appintern.Core.Services;

namespace Appintern.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpService, SmtpService>(Lifetime.Request);

            composition.Register<IArticleService, ArticleService>(Lifetime.Request);

            composition.Register(typeof(IDataTypeValueService), typeof(DataTypeValueService), Lifetime.Request);

            composition.Register<IApprenticeshipService, ApprenticeshipService>(Lifetime.Request);

            composition.Register(typeof(IMediaUploadService), typeof(MediaUploadService), Lifetime.Request);

            composition.Register<ISearchService, SearchService>(Lifetime.Request);
        }
    }
}
