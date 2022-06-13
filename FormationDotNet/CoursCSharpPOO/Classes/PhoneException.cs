using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class PhoneException : Exception
    {
        public PhoneException() : base("Erreur téléphone")
        {

        }
    }
}
