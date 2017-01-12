using log4net;
using OnlineTraining.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace OnlineTraining.UI
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger("Program.cs");
        private static void Divide()
        {
            try
            {
                int num1 = 10;
                int num2 = 0; //10;
                int result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                logger.Error(ex.Message); // can do logger.Fatal(ex.Message);
                Console.WriteLine("Divided by zero");
            }
        }
        static void Main(string[] args)
        {
            OnlineTrainingModel context = new OnlineTrainingModel();
            //ADDING A COURSE
            
            //Courses newCourse = new Courses() { courseName = "C# Programming", courseRating = "3 Stars", courseDurationHours = 150};
            //context.courses.Add(newCourse);
            //context.SaveChanges();

            //foreach (Courses course in context.courses)
            //{
            //    if (course.courseName == "C# Programming")
            //    {
            //        context.courses.Remove(course);
            //    }
            //}

            //context.SaveChanges();

            //Courses courseToUpdate = context.courses.Find(12);
            //courseToUpdate.courseName = "Python Programming";

            //context.SaveChanges();

            //foreach (Courses cs in context.courses)
            //{
            //    Console.WriteLine(cs.courseName);
            //}
            //Console.ReadLine();

            //ADDING A CUSTOMER

            //Customers newCustomer = new Customers() { customerFirstName = "Bishan", customerLastName = "Meghani", customerAddress = "46BrassieAvenue-W57DE", customerPhone = "07401700731", customerEmail = "bishan.meghani@yahoo.com", customerpassword = "sunshine" };
            //context.customers.Add(newCustomer);
            //context.SaveChanges();

            //foreach (Customers cust in context.customers)
            //{
            //    if (cust.customerFirstName == "Bishan")
            //    {
            //        context.customers.Remove(cust);
            //    }
            //}

            //context.SaveChanges();

            Divide();

            foreach (Customers cust in context.customers)
            {
                Console.WriteLine(cust.customerFirstName);
            }
            Console.ReadLine();
        }
    }
}
