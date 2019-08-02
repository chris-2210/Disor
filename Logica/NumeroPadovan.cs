using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroPadovan
    {
        private int numeroAnterior;
        private int numeroAnterior1;
        private int numeroAnterior2;
        private int valor;
        private int numeroVecesLlamado;
        private int numPadovan;

        public NumeroPadovan()
        {
            this.numeroAnterior = 1;
            this.numeroAnterior1 = 1;
            this.numeroAnterior2 = 1;
            this.numPadovan = 0;
            this.valor = 0;
            this.numeroVecesLlamado = 0;
        }

        public void incrementar()
        {
            avanzar();
        }

        public void decrementar()
        {
            retroceder();
        }

        private void avanzar()
        {
            if (numeroVecesLlamado == 0 || numeroVecesLlamado == 1 || numeroVecesLlamado == 2)
            {
                numPadovan = 1;
            }
            if (numeroVecesLlamado >= 3)
            {
                numeroAnterior = numeroAnterior1;
                numeroAnterior1 = numeroAnterior2;
                numeroAnterior2 = numPadovan;
                numPadovan = numeroAnterior + numeroAnterior1;
            }
            valor = numPadovan;
            numeroVecesLlamado += 1;
        }

        private void retroceder()
        {
            if (numeroVecesLlamado == 0 || numeroVecesLlamado == 1 || numeroVecesLlamado == 2)
            {
                numPadovan = 1;
            }
            if (numeroVecesLlamado >= 3)
            {
                numPadovan = numeroAnterior2;
                numeroAnterior2 = numeroAnterior1;
                numeroAnterior1 = numeroAnterior;
            }
            numeroVecesLlamado -= 1;
            valor = numPadovan;
        }

        public int numeroPadovan()
        {
            return valor;
        }
    }
}
