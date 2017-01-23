using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineTraining.EntityFramework;


namespace OnlineTraining.Logic
{
    public interface IShoppingCart
    {
        List<Courses> GetAllItems();
        void AddToCart(Courses item);
        void RemoveFromCart(Courses item);
        void EmptyTheCart();
        //int GetNumberOfItems();
        //double GetTotalPrice();
    }
    
    
    public class ShoppingCartLogic : IShoppingCart
    {
        List<Courses> myItems;
        int numberOfItems;
        double totalPrice;
        Reposit repo;

        public ShoppingCartLogic()
        {
            myItems = new List<Courses>();
            numberOfItems = 0;
            totalPrice = 0.0;
        }

        public void AddToCart(Courses item)
        {
            myItems.Add(item);
        }

        public void RemoveFromCart(Courses item)
        {
            myItems.Remove(item);
        }

        public void EmptyTheCart()
        {
            myItems.Clear();
        }

        public List<Courses> GetAllItems()
        {
            return myItems;
        }

        //public int GetNumberOfItems()
        //{
        //    numberOfItems = 0;
        //    foreach (Courses item in myItems)
        //    {
        //        numberOfItems = numberOfItems + item.
        //    }
        //    return numberOfItems;
        //}

        //public double GetTotalPrice()
        //{
        //    totalPrice = 0.0;
        //    foreach (Courses item in myItems)
        //    {
        //        totalPrice = totalPrice + item.coursePrice * item.;
        //    }
        //    return totalPrice;
        //}

        public Courses GetCourse(int courseId)
        {
            repo = new Reposit(new OnlineTrainingModel());

            Courses theCourse = repo.GetCourseById(courseId);

           if (theCourse != null)
           {
               return theCourse;
           }
           else
           {
               return new Courses();
           }           
        }
    }
}