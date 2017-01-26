using OnlineTraining.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.Logic
{
    public interface ICustomerLogic
    {
        int CustomerLogin(Customers customerToLogin);
        bool CustomerRegister(Customers customerToRegister);
    }
    
    public class CustomerLogic : ICustomerLogic
    {
        OnlineTrainingModel _context;
        Reposit repository;

        public CustomerLogic(OnlineTrainingModel context)
        {
            _context = context;
            repository = new Reposit(context);
        }

        public CustomerLogic(Reposit Repository)
        {
            repository = Repository;
        }

        public int CustomerLogin(Customers customerToLogin)
        {
            //repository = new Reposit(_context);
            //If Email exists and password match, you are logged in
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == true && repository.CheckUserPassword(customerToLogin.customerPassword) == true)
            {
                return 1;
            }
            //If Email doesn't exists you need to register
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == false && repository.CheckUserPassword(customerToLogin.customerPassword) == true)
            {
                return 2;
            }
            //If Email exists but wrong password
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == true && repository.CheckUserPassword(customerToLogin.customerPassword) == false)
            {
                return 3;
            }
            //If wrong email and wrong password
            return 0;
        }

        public bool CustomerRegister(Customers customerToRegister)
        {
            //repository = new Reposit(_context);
            if (repository.CheckIfUserHasAnAccount(customerToRegister.customerEmail) == true)
            {
                return true;
            }
            repository.AddCustomer(customerToRegister);
            return false;
        }

        public void RemoveAccount(Customers customerToRemove)
        {
            //repository = new Reposit(_context);
            repository.RemoveCustomerById(customerToRemove.customerId);
        }

        //public void CustomerEmailToName(OnlineTrainingModel context)
        //{
        //    modeldb.customers.Where(c => c.customerEmail == User.Identity.Name).ToList()[0];
        //}
        
    }
}
