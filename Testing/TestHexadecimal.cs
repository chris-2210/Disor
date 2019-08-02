using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Testing
{
    [TestClass]
    public class TestHexadecimal
    {
        [TestMethod]
        public void decimalCeroAHexadecimal()
        {
            NumeroHexadecimal numHexadecimal = new NumeroHexadecimal();
            numHexadecimal.decimalAHexadecimal(0);
            string valorEsperado = "0";
            string valorObtenido = numHexadecimal.numeroHexadecimal();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void numeroNegativoAHexadecimal()
        {
            NumeroHexadecimal numHexadecimal = new NumeroHexadecimal();
            numHexadecimal.decimalAHexadecimal(-1);
            string valorEsperado = "0";
            string valorObtenido = numHexadecimal.numeroHexadecimal();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void numeroFibonacci233()
        {
            NumeroHexadecimal numHexadecimal = new NumeroHexadecimal();
            numHexadecimal.decimalAHexadecimal(233);
            string valorEsperado = "E9";
            string valorObtenido = numHexadecimal.numeroHexadecimal();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void numeroFibonacci987()
        {
            NumeroHexadecimal numHexadecimal = new NumeroHexadecimal();
            numHexadecimal.decimalAHexadecimal(987);
            string valorEsperado = "3DB";
            string valorObtenido = numHexadecimal.numeroHexadecimal();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }
    }
}
