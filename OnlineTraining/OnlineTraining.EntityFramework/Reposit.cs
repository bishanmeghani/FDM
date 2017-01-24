using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public class Reposit
    {
        OnlineTrainingModel _context;

        public Reposit(OnlineTrainingModel context)
        {
            _context = context;
        }

        public virtual List<Courses> GetAllCourses()
        {
            return _context.courses.ToList();
        }

        public virtual List<Customers> GetAllCustomers()
        {
            return _context.customers.ToList();
        }

        public virtual List<Performances> GetAllPerformances()
        {
            return _context.performances.ToList();
        }

        public void AddCustomer(Customers customerToAdd)
        {
            _context.customers.Add(customerToAdd);
            _context.SaveChanges();
        }

        public void AddCourse(Courses courseToAdd)
        {
            _context.courses.Add(courseToAdd);
            _context.SaveChanges();
        }

        public void AddPerformance(Performances performanceToAdd)
        {
            _context.performances.Add(performanceToAdd);
            _context.SaveChanges();
        }

        public void RemoveCustomerById(int customerToRemoveId)
        {
            var query = from c in _context.customers where c.customerId == customerToRemoveId select c;

            foreach (var customer in query)
            {
                if (customer.customerId == customerToRemoveId)
                {
                    _context.customers.Remove(customer);
                }
            }

            _context.SaveChanges();
        }

        public void RemoveCourseById(int courseToRemoveId)
        {
            var query = from c in _context.courses where c.courseId == courseToRemoveId select c;

            foreach (var course in query)
            {
                if (course.courseId == courseToRemoveId)
                {
                    _context.courses.Remove(course);
                }
            }

            _context.SaveChanges();
        }

        public void RemovePerformanceById(int performanceToRemoveId)
        {
            var query = from p in _context.performances where p.performanceId == performanceToRemoveId select p;

            foreach (var performance in query)
            {
                if (performance.performanceId == performanceToRemoveId)
                {
                    _context.performances.Remove(performance);
                }
            }

            _context.SaveChanges();
        }

        public virtual Courses GetCourseById(int courseToGetId)
        {
            var query = from c in _context.courses where c.courseId == courseToGetId select c;

            return query.FirstOrDefault();
        }

        public void UpdateCustomerById(int customerToUpdateById, string thingToUpdate, string updatedThing)
        {
            var query = from uc in _context.customers where uc.customerId == customerToUpdateById select uc;
            
            foreach (var customer in query)
	        {
                if (thingToUpdate == "customerAdmin")
                {
                    customer.customerAdmin = Int32.Parse(updatedThing);
                }

		        if (thingToUpdate == "customerFirstName")
                {
                    customer.customerFirstName = updatedThing;
                }

                if (thingToUpdate == "customerLastName")
                {
                    customer.customerLastName = updatedThing;
                }

                if (thingToUpdate == "customerAddress")
                {
                    customer.customerAddress = updatedThing;
                }

                if (thingToUpdate == "customerPhone")
                {
                    customer.customerPhone = updatedThing;
                }

                if (thingToUpdate == "customerEmail")
                {
                    customer.customerEmail = updatedThing;
                }

                if (thingToUpdate == "customerPassword")
                {
                    customer.customerPassword = updatedThing;
                }
	        }
            _context.SaveChanges();
        }

        public void UpdateCourseById(int courseToUpdateById, string thingToUpdate, string updatedThing)
        {
            var query = from uc in _context.courses where uc.courseId == courseToUpdateById select uc;

            foreach (var course in query)
            {
                if (thingToUpdate == "courseName")
                {
                    course.courseName = updatedThing;
                }

                if (thingToUpdate == "courseRating")
                {
                    course.courseRating = Int32.Parse(updatedThing);
                }

                if (thingToUpdate == "courseDurationHours")
                {
                    course.courseDurationHours = Int32.Parse(updatedThing);
                }

                if (thingToUpdate == "coursePrice")
                {
                    course.coursePrice = Double.Parse(updatedThing);
                }
            }
            _context.SaveChanges();
        }

        public void UpdatePerformanceById(int performanceToUpdateById, string thingToUpdate, string updatedThing)
        {
            var query = from uc in _context.performances where uc.performanceId == performanceToUpdateById select uc;

            foreach (var performance in query)
            {
                if (thingToUpdate == "performancePercentage")
                {
                    performance.performancePercentage = Double.Parse(updatedThing);
                }
            }
            _context.SaveChanges();
        }

        public bool CheckIfUserHasAnAccount(string checkedEmailAddress)
        {
            var query = from c in _context.customers where c.customerEmail == checkedEmailAddress select c;

            foreach (var customer in query)
            {
                if (customer.customerEmail == checkedEmailAddress)
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool CheckUserPassword(string checkedPassword)
        {
            var query = from c in _context.customers where c.customerPassword == checkedPassword select c;

            foreach (var customer in query)
            {
                if (customer.customerPassword == checkedPassword)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
