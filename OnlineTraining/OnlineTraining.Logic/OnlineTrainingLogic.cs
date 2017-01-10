using log4net;
using System;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace OnlineTraining.Logic
{
    public class OnlineTrainingLogic
    {
        private static readonly ILog logger = LogManager.GetLogger("");
    }
}