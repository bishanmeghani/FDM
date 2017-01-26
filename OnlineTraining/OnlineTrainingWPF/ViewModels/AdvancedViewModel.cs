using OnlineTraining.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OnlineTrainingWPF.ViewModels
{
    public class AdvancedViewModel : BaseViewModel
    {
        Reposit repository;
        OnlineTrainingModel ModelDb;

        public AdvancedViewModel() 
        {
            ModelDb = new OnlineTrainingModel();
            repository = new Reposit(ModelDb);
        }

        private Customers _customer;

        public Customers customer
        {
            get { return _customer; }
            set 
            { 
                _customer = value; 
                OnPropertyChanged("customer"); 
            }
        }

        private List<Customers> _customerList;

        public List<Customers> customerList
        {
            get { return _customerList; }
            set 
            { 
                _customerList = value; 
                OnPropertyChanged("customerList"); 
            }
        }

        private ICommand _showListCommand;

        public ICommand showListCommand
        {
            get 
            {
                if (_showListCommand == null)
                {
                    _showListCommand = new Command(GetCustomers, CanGetCustomers);
                }
                return _showListCommand; 
            }
            set { _showListCommand = value; }
        }

        public void GetCustomers()
        {
            customerList = repository.GetAllCustomers();
        }

        public bool CanGetCustomers()
        {
            return true;
        }
        
    }
}
