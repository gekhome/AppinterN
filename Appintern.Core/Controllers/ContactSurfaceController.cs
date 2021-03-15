using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Reflection;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Appintern.Core.Models;
using Appintern.Core.Services;

namespace Appintern.Core.Controllers
{
    public class ContactSurfaceController   :   SurfaceController
    {
        private readonly ISmtpService _smtpService;

        // Inject the service to the controller constructor
        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
        }

        public string GetViewPath(string name)
        {
            return string.Format("~/Views/Partials/Contact/{0}.cshtml", name);
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel();
            return PartialView(GetViewPath("_ContactForm"), model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView(GetViewPath("_ContactForm"), model);
        }

        [HttpPost]
        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;
            if (ModelState.IsValid)
            {
                success = _smtpService.SendEmail(model);
            }
            return PartialView(GetViewPath(success ? "_Success" : "_Error"));
        }
    }

}

