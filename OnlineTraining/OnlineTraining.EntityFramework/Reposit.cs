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
    }
}
