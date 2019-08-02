using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Testing
{
    [TestClass]
    public class TestCapicua
    {
        [TestMethod]
        public void esCapicuaNumeroDosDigitos()
        {
            NumeroCapicua numCapicua = new NumeroCapicua();
            numCapicua.esCapicua(11);
            string valorEsperado = "Es capicua";
            string valorObtenido = numCapicua.resultadoCapicua();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void esCapicuaNumeroTresDigitos()
        {
            NumeroCapicua numCapicua = new NumeroCapicua();
            numCapicua.esCapicua(141);
            string valorEsperado = "Es capicua";
            string valorObtenido = numCapicua.resultadoCapicua();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void esCapicuaNumeroCuatroDigitos()
        {
            NumeroCapicua numCapicua = new NumeroCapicua();
            numCapicua.esCapicua(1441);
            string valorEsperado = "Es capicua";
            string valorObtenido = numCapicua.resultadoCapicua();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }
    }
}
