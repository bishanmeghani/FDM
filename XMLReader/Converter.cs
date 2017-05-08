using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Library
{
    public class Converter
    {
        public CurrencyTable currencyTable { get; set; }

        public Converter()
        {
            currencyTable = new CurrencyTable();
        }

        /*
         *  Converts an amount of money from a currency into another currency 
         *  using a conversion rate from a default currency conversion table
         */
        public double ConvertFromTo(double amount, string fromCurrency, string toCurrency)
        {
            double newAmount = 0d;

            double fromRate = currencyTable.GetConversionRate(fromCurrency);
            double toRate = currencyTable.GetConversionRate(toCurrency);

            if (fromRate > 0 && toRate > 0)
            {
                newAmount = amount * (toRate / fromRate);
            }

            return newAmount;
        }

        /*
         *  Converts an amount of Euros into the specified currency using a conversion rate from 
         *  a default currency conversion table
         */
        public double ConvertEurosTo(string currency, double amount)
        {
            double newAmount = 0d;
        
            double rate = currencyTable.GetConversionRate(currency);

            if ( rate > 0 )
            {
                newAmount = amount * rate;
            }

            return newAmount;
        }


    }
}
