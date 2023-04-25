using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstructIFAndELSEIF
    {
        public void LargestOfThree()
        {
            Console.WriteLine("Enter The 3 Integer: ");
            int first_Number = Convert.ToInt32(Console.ReadLine());
            int second_Number = Convert.ToInt32(Console.ReadLine());
            int third_Number = Convert.ToInt32(Console.ReadLine());
            if (first_Number > second_Number && first_Number > third_Number)
            {
                Console.WriteLine($"First Value is greater : {first_Number}");
            }
            else if (second_Number > first_Number && second_Number > third_Number)
            {
                Console.WriteLine($"Second Value is greater: {second_Number}");
            }
            else if (third_Number > first_Number && third_Number > second_Number)
            {
                Console.WriteLine($"Third Value is greater: {third_Number}");
            }
            else
            {
                Console.WriteLine("The numbers are equal.");
            }
        }
        public void EligibilityForAdmission()
        {
            
            Console.WriteLine("Enter the Marks of Physics");
            int physic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Chemistry");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            int total =  physic + chemistry + maths;
            if (total >= 180)
            {
                Console.WriteLine("Eligible");
            }
            else if ((maths + chemistry) >= 140 || (maths + physic) >= 140)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}
