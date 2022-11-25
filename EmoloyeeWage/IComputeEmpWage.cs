using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoloyeeWage
{
    internal class IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPermonth);
        public void ComputeEmpWage();
    }
}
