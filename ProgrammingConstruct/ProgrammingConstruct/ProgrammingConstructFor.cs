using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstructFor
    {
        public void PowerOfTwoTable()
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine($"The Table of 2 * {i} = "+ power);
            }
        }
    }
}
