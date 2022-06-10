using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    
    class Tools
    {
        public static decimal ParseDecimal(string value)
        {
            decimal result = 0;
            try
            {
                result = Convert.ToDecimal(value);
            }catch(Exception ex)
            {
                result = 0;
            }
            return result;
        }
    }
}
