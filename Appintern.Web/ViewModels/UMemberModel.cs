using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appintern.Web.ViewModels
{
    public class UMember
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Guid Key { get; set; }
        public string Login { get; set; }

        public string Email { get; set; }
        public string Type { get; set; }

        public string Group { get; set; }
        public DateTime LastLogin { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

    }
}