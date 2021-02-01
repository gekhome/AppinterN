
using Appintern.Core.Models;

namespace Appintern.Core.Services
{
    public interface ISmtpService
    {
        bool SendEmail(ContactViewModel model);

    }
}
