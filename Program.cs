using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FullTime = 1;
            const int PartTime = 2;
            const int WorkingDays = 20;
            const int empRatePerHr = 20;
            const int MaxHrsPerMonth = 100;
            int empHrs = 0;
            int empPayment = 0;
            int TotalPayment = 0;
            int TotalEmpHrs = 0;
            int day = 1;

            Random random = new Random();
            
            while(day <= WorkingDays && TotalEmpHrs <= MaxHrsPerMonth)
            {
              int empInput = random.Next(0, 3);

                switch(empInput)
                {
                    case FullTime:
                    empHrs = 8;
                        break;

                    case PartTime:
                    empHrs = 4;
                        break;

                    default:
                    empHrs = 0;
                        break;
                }
          
                empPayment = empRatePerHr * empHrs;
                Console.WriteLine("Daily Wage for day {0} is: {1} for {2} Hrs", day, empPayment, empHrs);
                TotalPayment += empPayment;
                TotalEmpHrs += empHrs;
                day++;
            
            }

            Console.WriteLine("Total Days {0}, Total Working hours: {1}", (day-1), TotalEmpHrs);
            Console.WriteLine("Total Employee Wage is: " + TotalPayment);
            Console.ReadLine();
        }
    }
}
