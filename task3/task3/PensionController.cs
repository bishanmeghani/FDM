using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    struct PensionController
    {
        public void HandlePensions(Person[] people)
        {
            view newview = new view();
            PersonLogic logic = new PersonLogic();
            bool truefalse;
            foreach (Person myperson in people)
            {
                truefalse = logic.IsPensionable(myperson, "2014");
                if (truefalse == true)
                {
                    newview.PrintEligible(myperson);
                }
                else
                {
                    newview.PrintIneligible(myperson);
                }
                
            }
        }
    }
}
            
            