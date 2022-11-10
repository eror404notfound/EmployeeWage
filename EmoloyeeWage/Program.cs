using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoloyeeWage
{
   
    internal class Program
    {
        
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUS = 20;
        static void Main(string[] args)
        {
           

            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();

            int empCheck = rand.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empCheck = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUS;
            Console.WriteLine("Emp Wage : " + empWage);

            Console.ReadLine();

        }
    }
}
