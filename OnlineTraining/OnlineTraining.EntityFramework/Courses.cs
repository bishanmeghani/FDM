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
        public int courseId { get; set; }

        [DisplayName("Course")]
        public string courseName { get; set; }

        [DisplayName("Rating")]
        public string courseRating { get; set; }

        [DisplayName("Course Length (in Hours)")]
        public int courseDurationHours { get; set; }

        [DisplayName("Course Price")]
        public double coursePrice { get; set; }

        public int GetCourseId()
        {
            return courseId;
        }

        public string GetCourseName()
        {
            return courseName;
        }

        public double GetCoursePrice()
        {
            return coursePrice;
        }
    }
}
