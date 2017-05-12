using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public class Courses
    {
        [Key]
        public virtual int courseId { get; set; }

        [DisplayName("Course")]
        public virtual string courseName { get; set; }

        [DisplayName("Rating")]
        public virtual int courseRating { get; set; }

        [DisplayName("Course Length (hours)")]
        public virtual int courseDurationHours { get; set; }

        [DisplayName("Course Price (£)")]
        public virtual double coursePrice { get; set; }
    }
}
