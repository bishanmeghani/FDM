using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{

    public delegate void ProcessPlayerDelegate(Footballer footballer);

    public class FootballerDatabase
    {
        List<Footballer> transferList = new List<Footballer>();

        public void AddFootballer(Footballer footballerToAdd)
        {
            transferList.Add(footballerToAdd);
        }


        public void ProcessInjuredPlayers(ProcessPlayerDelegate processPlayer)
        {
            foreach (Footballer footballer in transferList)
            {
                if (footballer.isInjured)
                {
                    processPlayer(footballer);
                }
                
            }
        }
    }
}
