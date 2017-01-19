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
            

            //Courses newCourse = new Courses() { courseName = "GCSE Maths", courseRating = 5, courseDurationHours = 100, coursePrice = 24.0};
            //Courses newCourse2 = new Courses() { courseName = "GCSE English", courseRating = 4, courseDurationHours = 90, coursePrice = 22.0 };
            //Courses newCourse3 = new Courses() { courseName = "GCSE Science", courseRating = 4, courseDurationHours = 80, coursePrice = 25.0 };
            //Courses newCourse4 = new Courses() { courseName = "A Level Maths", courseRating = 4, courseDurationHours = 100, coursePrice = 26.0 };
            //Courses newCourse5 = new Courses() { courseName = "A Level Physics", courseRating = 5, courseDurationHours = 90, coursePrice = 26.0 };
            //Courses newCourse6 = new Courses() { courseName = "A Level Chemistry", courseRating = 4, courseDurationHours = 90, coursePrice = 25.0 };
            //Courses newCourse7 = new Courses() { courseName = "A Level Biology", courseRating = 4, courseDurationHours = 90, coursePrice = 25.0 };
            //Courses newCourse8 = new Courses() { courseName = "French", courseRating = 3, courseDurationHours = 50, coursePrice = 23.0 };
            //Courses newCourse9 = new Courses() { courseName = "German", courseRating = 3, courseDurationHours = 50, coursePrice = 23.0 };
            //Courses newCourse10 = new Courses() { courseName = "Spanish", courseRating = 2, courseDurationHours = 50, coursePrice = 23.0 };
            //Courses newCourse11 = new Courses() { courseName = "Python Programming", courseRating = 4, courseDurationHours = 40, coursePrice = 28.0 };
            
            
            
            //Reposit repository1 = new Reposit(context);
            //repository1.AddCourse(newCourse);
            //repository1.AddCourse(newCourse2);
            //repository1.AddCourse(newCourse3);
            //repository1.AddCourse(newCourse4);
            //repository1.AddCourse(newCourse5);
            //repository1.AddCourse(newCourse6);
            //repository1.AddCourse(newCourse7);
            //repository1.AddCourse(newCourse8);
            //repository1.AddCourse(newCourse9);
            //repository1.AddCourse(newCourse10);
            //repository1.AddCourse(newCourse11);
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


            //Courses newItem = new Courses { courseId = 1, courseName = "GCSE Maths", courseRating = "4 Stars", courseDurationHours = 100, coursePrice = 20 };
            //Courses newItem2 = new Courses { courseId = 2, courseName = "GCSE English", courseRating = "3 Stars", courseDurationHours = 90, coursePrice = 30 };

            //IShoppingCart shoppingCart = new ShoppingCart();
            //shoppingCart.AddToCart(newItem);
            //shoppingCart.AddToCart(newItem2);
            
            //Console.WriteLine(shoppingCart.GetNumberOfItems());
            //Console.WriteLine(shoppingCart.GetTotalPrice());

            //Console.ReadLine();
            //shoppingCart.EmptyTheCart();
            //Console.WriteLine(shoppingCart.GetNumberOfItems());
            //Console.ReadLine();
        }
    }
}
