using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Appintern.Core.Models;
using Appintern.Core.Controllers;
using Umbraco.Core.Logging;

namespace Appintern.Core.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;

        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }

        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                string toAddress = System.Web.Configuration.WebConfigurationManager.AppSettings["ContactEmailTo"];
                string fromAddress = System.Web.Configuration.WebConfigurationManager.AppSettings["ContactEmailFrom"];

                if (string.IsNullOrEmpty(toAddress))
                    toAddress = "to.address@test.com";
                if (string.IsNullOrEmpty(fromAddress))
                    fromAddress = "from.address@test.com";

                message.Subject = string.Format("Enquiry from {0} - {1} with subject: {2}", model.Name, model.Email, model.Subject);
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, "Error submitting contact form.");
                return false;
            }
        }
    }
}
