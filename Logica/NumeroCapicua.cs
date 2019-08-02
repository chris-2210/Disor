using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroCapicua
    {
        int N = 0;
        string resultado;

        public NumeroCapicua()
        {
            this.resultado = "";
        }

        public void esCapicua(int numeroDecimal)
        {
            if (numeroDecimal <= 9)
            {
                resultado = "No es capicua";
            }
            if (numeroDecimal > 9)
            {
                calculoCapicua(numeroDecimal);
            }
        }

        private void calculoCapicua(int numero)
        {
            int aux, inverso = 0, cifra;
            aux = numero;
            while (aux != 0)
            {
                cifra = aux % 10;
                inverso = inverso * 10 + cifra;
                aux = aux / 10;
            }
            if (numero != inverso)
            {
                resultado = "No es capicua";
            }
            if (numero == inverso)
            {
                resultado = "Es capicua";
            }
        }

        public string resultadoCapicua()
        {
            return resultado;
        }
    }
}
