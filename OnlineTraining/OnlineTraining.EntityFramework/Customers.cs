using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public class Customers
    {
        [Key]
        public int customerId { get; set; }

        [DisplayName("Admin")]
        public int customerAdmin { get; set; }

        [DisplayName("First name")]
        public string customerFirstName { get; set; }

        [DisplayName("Last name")]
        public string customerLastName { get; set; }

        [DisplayName("Address")]
        public string customerAddress { get; set; }

        [DisplayName("Phone number")]
        public string customerPhone { get; set; }

        [DisplayName("Email address")]
        public string customerEmail { get; set; }

        [DisplayName("Password")]
        public string customerPassword { get; set; }

        
    }
}
