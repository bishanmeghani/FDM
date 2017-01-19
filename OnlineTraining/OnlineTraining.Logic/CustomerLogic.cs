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
        }

        public int CustomerLogin(Customers customerToLogin)
        {
            repository = new Reposit(_context);
            //If Email and password match, you are logged in
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == true && repository.CheckUserPassword(customerToLogin.customerPassword) == true)
            {
                return 1;
            }

            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == false)
            {
                return 2;
            }

            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == true && repository.CheckUserPassword(customerToLogin.customerPassword) == false)
            {
                return 3;
            }
            return 0;
        }

        public bool CustomerRegister(Customers customerToRegister)
        {
            repository = new Reposit(_context);
            if (repository.CheckIfUserHasAnAccount(customerToRegister.customerEmail) == true)
            {
                return true;
            }
            repository.AddCustomer(customerToRegister);
            return false;
        }
    }
}
