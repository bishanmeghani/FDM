using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyConverter.Library
{
    public class XMLRead
    {
        public Dictionary<string, double> ReadFromCurrencyXML()
        {
            Dictionary<string, double> currencyDictionary = new Dictionary<string, double>();
            currencyDictionary.Add("EUR", 1.00);

            // Create an XML reader for this file. It is reading the currencies and rates from C#Day13-CurrencyConverterData.xml
            using (XmlReader reader = XmlReader.Create("C#Day13-CurrencyConverterData.xml"))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        if (reader.Name == "Cube")
                        {
                            // Detect this element.
                            string currencyName = reader["currency"];
                            if (currencyName == null)
                            {
                                continue;
                            }

                            string currencyRate = reader["rate"];
                            if (currencyRate == null)
                            {
                                continue;
                            }
                            double currencyRateValue;
                            currencyRateValue = Convert.ToDouble(currencyRate);

                            currencyDictionary.Add(currencyName, currencyRateValue);
                        }
                    }
                }
            }
            return currencyDictionary;
        }
    }
}