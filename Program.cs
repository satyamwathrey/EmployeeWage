using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FullTime = 1;
            const int PartTime = 2;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empPayment = 0;
            Random random = new Random();
            int empInput = random.Next(0, 3);

            switch(empInput)
            {
                case FullTime:
                Console.WriteLine("Full time Employee is present");
                empHrs = 8;
                empPayment = empRatePerHr * empHrs;
                    break;

                case PartTime:
                Console.WriteLine("Part time Employee is present ");
                empHrs = 4;
                empPayment = empRatePerHr * empHrs;
                    break;

                default:
                Console.WriteLine("Employee is absent");
                empHrs = 0;
                empPayment = empRatePerHr * empHrs;
                    break;
            }
          
            Console.WriteLine("Daily Employee Payment is: " + empPayment);
            Console.ReadLine();
        }
    }
}
