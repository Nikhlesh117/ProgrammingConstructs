using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstructCase
    {
        public void NumberToWeekDay() 
        {
            Console.WriteLine("Enter the week day number");
            int weekday = Convert.ToInt32(Console.ReadLine()); 
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }
        public void ArithmeticOperations()
        {
            Console.WriteLine("Enter the Two Number ");
            int first_Number = Convert.ToInt32(Console.ReadLine());
            int second_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press:\n1. Addition\n2. Substraction\n3. Multiplication\n4. division\n ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Addition Two Integer : {first_Number + second_Number}");
                    break;
                case 2:
                    Console.WriteLine($"Substraction Two Integer : {first_Number - second_Number}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication Two Integer : {first_Number * second_Number}");
                    break;
                case 4:
                    Console.WriteLine($"Division Two Integer : {first_Number / second_Number}");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
