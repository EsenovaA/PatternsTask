using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory
{
    public class Cooker : ICooker
    {
        public void FryChicken(int amount, Level level)
        {
            Console.WriteLine($"{level} fry {amount} of chicken.");
        }

        public void FryRice(int amount, Level level)
        {
            Console.WriteLine($"{level} fry {amount} of rice.");
        }

        public void PepperChicken(Level level)
        {
            Console.WriteLine($"Pepper chicken {level}");
        }

        public void PepperRice(Level level)
        {
            Console.WriteLine($"Pepper rice {level}");
        }

        public void SaltChicken(Level level)
        {
            Console.WriteLine($"Salt chicken {level}");
        }

        public void SaltRice(Level level)
        {
            Console.WriteLine($"Salt rice {level}");
        }
    }
}
