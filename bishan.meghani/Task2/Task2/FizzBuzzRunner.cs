using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class FizzBuzzRunner
    {
        public void FizzBuzz(int number)
        { 
            for (int i = 1; i <= number; i++)
            {
                if (IsFizzBuzz(i) == true)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (IsFizz(i) == true)
                {
                    Console.WriteLine("Fizz");
                }
                else if (IsBuzz(i) == true)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        private bool IsFizz(int num)
        {
            bool truefalse = false;
            if (num % 3 == 0)
            {
                truefalse = true;
            }
            else
            {
                truefalse = false;
            }
            return truefalse;
        }
        private bool IsBuzz(int num)
        {
            bool truefalse = false;
            if (num % 5 == 0)
            {
                truefalse = true;
            }
            else
            {
                truefalse = false;
            }
            return truefalse;
        }
        private bool IsFizzBuzz(int num)
        {
            bool truefalse = false;
            if (num % 3 ==0 && num % 5 == 0)
            {
                truefalse = true;
            }
            else
            {
                truefalse = false;
            }
            return truefalse;
        }
    }
}
