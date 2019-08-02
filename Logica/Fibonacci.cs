using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Fibonacci
    {
        private int numeroActual;
        private int numeroAnterior;
        private int numeroVecesLlamado;
        private int valor;

        public Fibonacci()
        {
            valor = 0;
        }

        public void incrementar()
        {
            siguiente();
        }

        public void decrementar()
        {
            anterior();
        }

        private void siguiente()
        {

            if (numeroVecesLlamado <= 0)
            {
                numeroAnterior = 0;
                numeroActual = 0;
                numeroVecesLlamado = 0;
            }
            if (numeroVecesLlamado == 1)
            {
                numeroAnterior = 0;
                numeroActual = 1;
            }
            if (numeroVecesLlamado >= 2)
            {
                int respaldonumeroanterior = numeroAnterior;
                numeroAnterior = numeroActual;
                numeroActual = numeroAnterior + respaldonumeroanterior;
                //throw()
            }
            valor = numeroActual;
            numeroVecesLlamado += 1;
        }

        public void anterior()
        {
            if (numeroVecesLlamado <= 0)
            {

                numeroActual = 0;
                numeroAnterior = 0;
                valor = numeroActual;
                numeroVecesLlamado = 0;
             }
             int respaldoNumeroActual = numeroActual;
             numeroActual = numeroAnterior;
             numeroAnterior = respaldoNumeroActual - numeroActual;
             valor = numeroActual;
             numeroVecesLlamado -= 1;
        }

        public int numeroFibonacci()
        {
            return valor;
        }
    }
}
