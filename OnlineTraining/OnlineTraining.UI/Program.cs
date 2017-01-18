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
            


            //Courses newCourse = new Courses() { courseName = "C# Programming", courseRating = "3 Stars", courseDurationHours = 150, coursePrice = 400};
            //Reposit repository1 = new Reposit(context);
            //repository1.UpdateCourseById(16,"coursePrice","300");


            //Reposit repository1 = new Reposit(context);
            //repository1.RemoveCourseById(16);

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

            ////Customers newCustomer = new Customers() { customerFirstName = "Bishan", customerLastName = "Meghani", customerAddress = "46BrassieAvenue-W57DE", customerPhone = "07401700731", customerEmail = "bishan.meghani@yahoo.com", customerpassword = "sunshine" };
            Reposit repository1 = new Reposit(context);
            ////repository1.AddCustomer(newCustomer);
                                  
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

            //Divide();

            ////ADDING PRICES
            //Courses coursePriceToUpdate = context.courses.Find(1);
            //coursePriceToUpdate.coursePrice = 20.00;
            //Courses coursePriceToUpdate2 = context.courses.Find(2);
            //coursePriceToUpdate2.coursePrice = 30.00;
            //Courses coursePriceToUpdate3 = context.courses.Find(3);
            //coursePriceToUpdate3.coursePrice = 15.00;
            //Courses coursePriceToUpdate4 = context.courses.Find(4);
            //coursePriceToUpdate4.coursePrice = 17.00;
            //Courses coursePriceToUpdate5 = context.courses.Find(5);
            //coursePriceToUpdate5.coursePrice = 22.00;
            //Courses coursePriceToUpdate6 = context.courses.Find(6);
            //coursePriceToUpdate6.coursePrice = 25.00;
            //Courses coursePriceToUpdate7 = context.courses.Find(7);
            //coursePriceToUpdate7.coursePrice = 33.00;
            //Courses coursePriceToUpdate8 = context.courses.Find(8);
            //coursePriceToUpdate8.coursePrice = 36.00;
            //Courses coursePriceToUpdate9 = context.courses.Find(9);
            //coursePriceToUpdate9.coursePrice = 34.00;
            //Courses coursePriceToUpdate10 = context.courses.Find(10);
            //coursePriceToUpdate10.coursePrice = 32.00;
            //Courses coursePriceToUpdate11 = context.courses.Find(11);
            //coursePriceToUpdate11.coursePrice = 33.00;
            //Courses coursePriceToUpdate12 = context.courses.Find(12);
            //coursePriceToUpdate12.coursePrice = 40.00;
            
            //context.SaveChanges();
            
            //foreach (Courses cs in context.courses)
            //{
            //    Console.WriteLine(cs.coursePrice);
            //}
            //Console.ReadLine();


            Courses newItem = new Courses { courseId = 1, courseName = "GCSE Maths", courseRating = "4 Stars", courseDurationHours = 100, coursePrice = 20 };
            Courses newItem2 = new Courses { courseId = 2, courseName = "GCSE English", courseRating = "3 Stars", courseDurationHours = 90, coursePrice = 30 };

            IShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddToCart(newItem);
            shoppingCart.AddToCart(newItem2);
            
            Console.WriteLine(shoppingCart.GetNumberOfItems());
            Console.WriteLine(shoppingCart.GetTotalPrice());

            Console.ReadLine();
            //shoppingCart.EmptyTheCart();
            //Console.WriteLine(shoppingCart.GetNumberOfItems());
            //Console.ReadLine();
        }
    }
}
