using System;
using System.Collections.Generic;
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
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerAddress { get; set; }
        public string customerPhone { get; set; }
        public string customerEmail { get; set; }
        public string customerpassword { get; set; }
    }
}
