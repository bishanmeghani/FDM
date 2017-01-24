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
        public virtual int customerId { get; set; }

        [DisplayName("Admin")]
        public virtual int customerAdmin { get; set; }

        [DisplayName("First name")]
        public virtual string customerFirstName { get; set; }

        [DisplayName("Last name")]
        public virtual string customerLastName { get; set; }

        [DisplayName("Address")]
        public string customerAddress { get; set; }

        [DisplayName("Phone number")]
        public string customerPhone { get; set; }

        [DisplayName("Email address")]
        public virtual string customerEmail { get; set; }

        [DisplayName("Password")]
        public virtual string customerPassword { get; set; }

        
    }
}
