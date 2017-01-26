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
        private string _message;
        public string message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("message");
            }
        }

        private bool CanChangeText()
        {
            //we could put logic in here to test whether the button can be clicked
            return true;
        }

        private void ChangeText()
        {
            message = "Today is Friday";
        }

        public AdvancedViewModel()
        {
            message = "Today is Tuesday!";
        }

        
    }
}
