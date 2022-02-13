using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxxstepTest.Web.Models
{
    public class ContactViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long ReportTo { get; set; }
    }
}
