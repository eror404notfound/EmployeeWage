using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoloyeeWage
{
   
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;    //Considered per Hr rate -20 .
        public const int NUM_OF_WORKING_DAYS = 4;      //Considered Woriking days
        public const int MAX_HRS_IN_MONTH = 16;        //Considered Emp can max work only 16 hrs in a month .
        public static int ComputeEmpWage()      //Calculate Emp Wage .
        {
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS) 
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);   //output will confirm if the Emp is working as Full_time , Part_time or Absent .
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                if (totalEmpHrs > MAX_HRS_IN_MONTH)  //totalEmpHrs should not go beyond defined MaxHrs .
                {
                    totalEmpHrs = MAX_HRS_IN_MONTH;
                }
                Console.WriteLine("Day#:" + totalWorkingDays + "  " + "Working Hours : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;     //totalWage is nothing but the product of no of hours he have been worked with his rate .
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();

        }
    }
}
