using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoloyeeWage
{
    public class EmpWageBuilderArray : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        List<CompanyEmpWage> listObj = new List<CompanyEmpWage>();  //using List .
        private CompanyEmpWage companyEmpWageObj;
        public void AddCompanyEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPermonth)
        {
            this.companyEmpWageObj = new CompanyEmpWage(company, empRateperHour, numOfWorkingDays, maxHoursPermonth);
            listObj.Add(this.companyEmpWageObj);
        }
        public void ComputeEmpWage()
        {
            foreach (var item in listObj)
            {
                companyEmpWageObj.SetTotalEmpWage(ComputeEmpWage(item));
                item.SetTotalEmpWage(companyEmpWageObj.totalEmpWage);
                Console.WriteLine(item.ToString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                int wageUpToDate = totalEmpHrs * companyEmpWage.empRatePerHour;//calculating till the date earned amount .
                Console.WriteLine("Days#:" + totalWorkingDays + " Emp Hrs:" + empHrs + " and Wage till day " + totalWorkingDays + " is:" + wageUpToDate);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}