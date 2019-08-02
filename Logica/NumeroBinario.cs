using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroBinario
    {
        private String binario;

        public void decimalABinario(int numeroDecimal)
        {
            this.binario = "";
            if (numeroDecimal == 0 || numeroDecimal < 0)
            {
                binario += "0";
            }
            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 2;
                numeroDecimal = numeroDecimal / 2;
                binario = resto.ToString() + binario;
            }
        }

        public String numeroBinario()
        {
            return binario;
        }

    }
}

