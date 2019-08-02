using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroFeliz
    {
        private int numero;
        private double suma, digito;
        private string resultado;

        public NumeroFeliz()
        {
            this.numero = 0;
            this.suma = 0;
            this.digito = 0;
        }
        
        public void esFeliz(int numeroDecimal)
        {
            calculoFeliz(numeroDecimal);
        }

        private void calculoFeliz(int numeroD)
        {

        }
    }
}
