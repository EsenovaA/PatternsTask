using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory
{
    public interface ICooker
    {
        void FryRice(int amount, Level level);

        void FryChicken(int amount, Level level);

        void SaltRice(Level level);

        void SaltChicken(Level level);

        void PepperRice(Level level);

        void PepperChicken(Level level);
    }
}
