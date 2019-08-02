using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Testing
{
    [TestClass]
    public class TestPadovan
    {
        [TestMethod]
        public void avanzarUnaVezPadovan()
        {
            NumeroPadovan numPadovan = new NumeroPadovan();
            numPadovan.incrementar();
            int numeroEsperado = 1;
            int numeroObtenido = numPadovan.numeroPadovan();
            Assert.AreEqual(numeroEsperado, numeroObtenido);
        }

        [TestMethod]
        public void avanzarTresVecesPadovan()
        {
            NumeroPadovan numPadovan = new NumeroPadovan();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            int numeroEsperado = 1;
            int numeroObtenido = numPadovan.numeroPadovan();
            Assert.AreEqual(numeroEsperado, numeroObtenido);
        }

        [TestMethod]
        public void avanzarCincoVecesPadovan()
        {
            NumeroPadovan numPadovan = new NumeroPadovan();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            int numeroEsperado = 2;
            int numeroObtenido = numPadovan.numeroPadovan();
            Assert.AreEqual(numeroEsperado, numeroObtenido);
        }

        [TestMethod]
        public void avanzarSieteVecesPadovan()
        {
            NumeroPadovan numPadovan = new NumeroPadovan();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            numPadovan.incrementar();
            int numeroEsperado = 4;
            int numeroObtenido = numPadovan.numeroPadovan();
            Assert.AreEqual(numeroEsperado, numeroObtenido);
        }
    }
}
