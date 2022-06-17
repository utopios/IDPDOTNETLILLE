using CoursCSharpPOO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    public class FakeGenerateur : IGenerateur
    {
        public string Generer()
        {
            return "coucou";
        }
    }
}
