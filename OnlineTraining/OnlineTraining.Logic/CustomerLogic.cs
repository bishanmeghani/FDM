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
        
    }
    
    public class CustomerLogic : ICustomerLogic
    {
        OnlineTrainingModel _context;

        public CustomerLogic(OnlineTrainingModel context)
        {
            _context = context;
        }

        public int CustomerLogin(Customers customerToLogin)
        {
            Reposit repository = new Reposit(_context);
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
    }
}
