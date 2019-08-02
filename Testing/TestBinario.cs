using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Testing
{
    [TestClass]
    public class TestBinario
    {
        [TestMethod]
        public void decimalCeroABinario()
        {
            NumeroBinario numBinario = new NumeroBinario();
            numBinario.decimalABinario(0);
            string resultadoEsperado = "0";
            string resultadoObtenido = numBinario.numeroBinario();
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void numeroFibonacci13()
        {
            NumeroBinario numBinario = new NumeroBinario();
            numBinario.decimalABinario(13);
            string resultadoEsperado = "1101";
            string resultadoObtenido = numBinario.numeroBinario();
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void numeroFibonacci89()
        {
            NumeroBinario numBinario = new NumeroBinario();
            numBinario.decimalABinario(89);
            string resultadoEsperado = "1011001";
            string resultadoObtenido = numBinario.numeroBinario();
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void numeroNegativoABinario()
        {
            NumeroBinario numBinario = new NumeroBinario();
            numBinario.decimalABinario(-1);
            string resultadoEsperado = "0";
            string resultadoObtenido = numBinario.numeroBinario();
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
