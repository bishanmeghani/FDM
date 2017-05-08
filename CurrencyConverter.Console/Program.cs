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
                    
                    case 'm':
                        MenuOfCurrencies();
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
            System.Console.WriteLine("m - Menu of Currencies");
            System.Console.WriteLine("-----------------------");
        }

        static void MenuOfCurrencies()
        {
            System.Console.WriteLine("\nUSD (United States Dollar)");
            System.Console.WriteLine("JPY (Japanese Yen)");
            System.Console.WriteLine("BGN (Bulgarian Lev)");
            System.Console.WriteLine("CZK (Czech Republic Koruna)");
            System.Console.WriteLine("DKK (Danish Krone)");
            System.Console.WriteLine("GBP (British Pound)");
            System.Console.WriteLine("HUF (Hungarian Forint)");
            System.Console.WriteLine("PLN (Polish Zloty)");
            System.Console.WriteLine("RON (Romanian Leu)");
            System.Console.WriteLine("SEK (Swedish Krona)");
            System.Console.WriteLine("CHF (Swiss Franc)");
            System.Console.WriteLine("NOK (Norwegian Krone)");
            System.Console.WriteLine("HRK (Croation Kuna)");
            System.Console.WriteLine("RUB (Russian Ruble)");
            System.Console.WriteLine("TRY (Turkish Lira)");
            System.Console.WriteLine("AUD (Austrialian Dollar)");
            System.Console.WriteLine("BRL (Brazilian Real)");
            System.Console.WriteLine("CAD (Canadian Dollar)");
            System.Console.WriteLine("CNY (Chinese Yuan)");
            System.Console.WriteLine("HKD (Hong Kong Dollar)");
            System.Console.WriteLine("IDR (Indonesian Rupiah)");
            System.Console.WriteLine("ILS (Israeli New Shekel)");
            System.Console.WriteLine("INR (Indian Rupee)");
            System.Console.WriteLine("KRW (South Korean Won)");
            System.Console.WriteLine("MXN (Mexican Peso)");
            System.Console.WriteLine("MYR (Malaysian Ringgit)");
            System.Console.WriteLine("NZD (New Zealand Dollar)");
            System.Console.WriteLine("PHP (Phillipine Peso)");
            System.Console.WriteLine("SGD (Singapore Dollar)");
            System.Console.WriteLine("THB (Thai Baht)");
            System.Console.WriteLine("ZAR (South African Rand)");

        }
    }
}




