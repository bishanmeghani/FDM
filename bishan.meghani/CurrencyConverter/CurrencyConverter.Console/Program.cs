using System;
using CurrencyConverter.Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace CurrencyConverter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            char input = '0';
            string currencyA, currencyB;
            double originalAmount, newAmount;
            

            while( input != 'q')
            {
                PrintMenu();
                input = System.Console.ReadKey().KeyChar;

                switch(input)
                {
                    default:
                        System.Console.WriteLine("Invalid Input");
                        continue;

                    case 'q':
                        continue;
                        


                    case '1': // Euros to other currency
                        // Enter new currency
                        System.Console.Write("\nEnter New Currency ID: ");
                        currencyB = System.Console.ReadLine();

                        // Enter amount of Euros
                        try
                        {
                            System.Console.Write("\nEnter Amount of Euros: ");
                            originalAmount = Convert.ToDouble(System.Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                            continue;
                        }

                        // Calculate converted currency and print
                        try
                        {
                            newAmount = converter.ConvertEurosTo(currencyB, originalAmount);
                            System.Console.WriteLine("\nNew Amount in " + currencyB + ": " + newAmount);
                        }
                        catch (CurrencyNotFoundException cnf)
                        {
                            System.Console.WriteLine("\n" + cnf.Message);
                        }
                        break;




                    case '2': // Currency A to Currency B
                        // Enter first currency
                        System.Console.Write("\nEnter Current Currency: ");
                        currencyA = System.Console.ReadLine();

                        // Enter second currency
                        System.Console.Write("\nEnter New Currency: ");
                        currencyB = System.Console.ReadLine();

                        
                        try
                        {
                            // Enter amount of first currency
                            System.Console.Write("\nEnter Amount: ");
                            originalAmount = Convert.ToDouble(System.Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                            continue;
                        }

                        // Calculate converted currency and print
                        try
                        { 
                            newAmount = converter.ConvertFromTo(originalAmount, currencyA, currencyB);                        
                            System.Console.WriteLine("\nNew Amount in " + currencyB + ": " + newAmount);
                        }
                        catch (CurrencyNotFoundException cnf)
                        {
                            System.Console.WriteLine("\n" + cnf.Message);
                        }
                        break;

                }

            }

        }

        static void PrintMenu()
        {
            System.Console.WriteLine("\nCurrency Converter");
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("1 - Convert from Euros to other currency");
            System.Console.WriteLine("2 - Convert from currencies A to B");
            System.Console.WriteLine("q - Quit");
            System.Console.WriteLine("-----------------------");
        }
    }
}




