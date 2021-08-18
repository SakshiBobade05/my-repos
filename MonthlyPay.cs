using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MonthlyPay
    {
        static void Main()
        {
            Console.WriteLine("Enter Monthly Payment:");
            Double m = double.Parse(Console.ReadLine());
            int month = 0;
            double loan = 1000;
            while (loan > m)
            {
                loan *= 1.015;
                loan -= m;
                Console.WriteLine("Balance: " + loan + "  Month: " + (++month) + " Total Payments:" + (m * month));
            }
        }
    }
}
