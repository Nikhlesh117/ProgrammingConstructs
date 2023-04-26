using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstructWhile
    {
        public void FlipCoin()
        {
            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();
            while (headsCount < 20 && tailsCount < 20)
            {
                int flip = random.Next(2);
                if (flip == 0)
                {
                    headsCount++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tailsCount++;
                    Console.WriteLine("Tails");
                }
            }
            if (headsCount == 20)
            {
                Console.WriteLine("Heads wins");
            }
            else
            {
                Console.WriteLine("Tails wins");
            }
        }
    }
}
