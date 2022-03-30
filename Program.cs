using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empPayment = 0;
            Random random = new Random();
            int empInput = random.Next(0, 3);

            if (isFullTime == empInput)
            {
                Console.WriteLine("Full time Employee is present");
                empHrs = 8;
                empPayment = empRatePerHr * empHrs;
            }
            else if (isPartTime == empInput)
            {
                Console.WriteLine("Part time Employee is present ");
                empHrs = 4;
                empPayment = empRatePerHr * empHrs;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
                empPayment = empRatePerHr * empHrs;

            }
            Console.WriteLine("Daily Employee Payment is: " + empPayment);
            Console.ReadLine();
        }
    }
}
