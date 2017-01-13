using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public class Courses
    {
        [Key]
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseRating { get; set; }
        public int courseDurationHours { get; set; }
        public double coursePrice { get; set; }
    }
}
