using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    internal class Dice : IDice
    {
        public int GetRandom()
        {
            return new Random().Next(1,7);
        }
    }
}
