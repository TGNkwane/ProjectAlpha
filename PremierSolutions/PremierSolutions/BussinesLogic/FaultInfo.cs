using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierSolutions;
using PremierSolutions.DataAccess;

namespace PremierSolutions.BussinesLogic
{
    class FaultInfo : CallStats
    {
        public string ReportFault()
        {
            string faultReport = "";

            return faultReport;
        }
        public void LogProblemInfoIntoDB()
        {
            //not necessary. Doing this in the call class
        }
    }
}
