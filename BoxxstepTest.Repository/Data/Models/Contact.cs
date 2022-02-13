using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoxxstepTest.Repository.Data.Models
{
    public class Contact
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public long Parent { get; set; }
        public string Relations { get; set; }
    }
}
