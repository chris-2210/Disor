using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroHexadecimal
    {
        private String hexadecimal;

        public void decimalAHexadecimal(int numeroDecimal)
        {
            int rem;
            hexadecimal = "";
            char[] caracterHex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (numeroDecimal == 0 || numeroDecimal < 0)
            {
                hexadecimal += "0";
            }
            while (numeroDecimal > 0)
            {
                rem = numeroDecimal % 16;
                hexadecimal = caracterHex[rem] + hexadecimal;
                numeroDecimal = numeroDecimal / 16;
            }
        }

        public String numeroHexadecimal()
        {
            return hexadecimal;
        }
    }
}