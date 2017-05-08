using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Library
{
    public class CurrencyNotFoundException : Exception
    {
        public CurrencyNotFoundException(string message) : base(message) { }
    }

    public class CurrencyTable
    {
        public Dictionary<string, double> currencyTable { get; set; }
        public XMLRead xmlReader { get; set; }



        public CurrencyTable()
        {
            xmlReader = new XMLRead();
            currencyTable = xmlReader.ReadFromCurrencyXML();
        }


        /*
         *  Adds a single conversion rate from Euros to another currency to the table.
         */
        public void AddConversionRate(string currency, double rate)
        {
            // Check if currency is a 3-letter ID and rate is > 0
            if (rate > 0d)
            {
                // Add currency ID and rate to dictionary
                currencyTable.Add(currency, rate);
            }
        }


        /*
         *  Gets a single conversion rate from to another currency from the table.
         */
        public double GetConversionRate(string currency)
        {
            double rate = -1.0;

            // Check if currency exists in the table
            if (currencyTable.ContainsKey(currency))
            {
                currencyTable.TryGetValue(currency, out rate);
            }

            if ( rate == -1.0 ) throw new CurrencyNotFoundException("Currency not found in table.");

            return rate;
        }


    }
}
