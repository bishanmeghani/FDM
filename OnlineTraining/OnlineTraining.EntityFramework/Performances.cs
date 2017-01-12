using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public class Performances
    {
        [Key]
        public int performanceId { get; set; }
        public double performancePercentage { get; set; }
    }
}
