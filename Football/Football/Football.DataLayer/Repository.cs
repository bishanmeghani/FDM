using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DataLayer
{
    public class Repository
    {
        public static List<Team> GetTeams()
        {
            var teams = new List<Team>()
            {
                new Team { Name = "Arsenal" },
                new Team { Name = "Chelsea" },
                new Team { Name = "Manchester United" },
                new Team { Name = "Liverpool" }
            };
            return teams;
        }
    }
}
