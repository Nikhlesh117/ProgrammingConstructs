using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstructIFELSE
    {
        public void EqualOrNot()
        {
            Console.WriteLine("Enter Two Integers");
            int integer_One = Convert.ToInt32(Console.ReadLine());
            int integer_Two = Convert.ToInt32(Console.ReadLine());
            if(integer_One == integer_Two)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter Value");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
