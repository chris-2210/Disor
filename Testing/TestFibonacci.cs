using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Testing
{
    [TestClass]
    public class TestFibonacci
    {
        [TestMethod]
        public void AvanzarUnaVez()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            int valorEsperado = 0;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void AvanzarTresVeces()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            int valorEsperado = 1;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void AvanzarCincoVeces()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            int valorEsperado = 3;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void AvanzarCincoVecesDecrementarUnaVez()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.decrementar();
            int valorEsperado = 2;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void AvanzarCincoVecesDecrementarDosVeces()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            int valorEsperado = 1;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void AvanzarCincoVecesDecrementarCuatroVeces()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            int valorEsperado = 0;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void decrementarUnaVez()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.decrementar();
            int valorEsperado = 0;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void incrementarTresVecesDecrementarCincoVecesIncrementarDosVeces()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            int valorEsperado = 1;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void decrementarTresVecesConvertirABinario()
        {
            Fibonacci fibonacci = new Fibonacci();
            NumeroBinario numBinario = new NumeroBinario();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            numBinario.decimalABinario(fibonacci.numeroFibonacci());
            string valorEsperado = "0";
            string valorObtenido = numBinario.numeroBinario();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void decrementarDosVecesConvertirAHexadecimal()
        {
            Fibonacci fibonacci = new Fibonacci();
            NumeroHexadecimal numHexadecimal = new NumeroHexadecimal();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            numHexadecimal.decimalAHexadecimal(fibonacci.numeroFibonacci());
            string valorEsperado = "0";
            string valorObtenido = numHexadecimal.numeroHexadecimal();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void avanzarVeinteVecesConvertirAHexadecimal()
        {
            Fibonacci fibonacci = new Fibonacci();
            NumeroHexadecimal numHexadecimal = new NumeroHexadecimal();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            numHexadecimal.decimalAHexadecimal(fibonacci.numeroFibonacci());
            string valorEsperado = "1055";
            string valorObtenido = numHexadecimal.numeroHexadecimal();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void avanzarQuiceVecesConvertirABinario()
        {
            Fibonacci fibonacci = new Fibonacci();
            NumeroBinario numBinario = new NumeroBinario();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            numBinario.decimalABinario(fibonacci.numeroFibonacci());
            string valorEsperado = "101111001";
            string valorObtenido = numBinario.numeroBinario();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void decrementarSieteVecesIncrementarOchoVeces()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            int valorEsperado = 13;
            int valorObtenido = fibonacci.numeroFibonacci();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }

        [TestMethod]
        public void decrementarCincoVecesIncrementarCincoVecesConvertirABinario()
        {
            Fibonacci fibonacci = new Fibonacci();
            NumeroBinario numBinario = new NumeroBinario();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.decrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            fibonacci.incrementar();
            numBinario.decimalABinario(fibonacci.numeroFibonacci());
            string valorEsperado = "11";
            string valorObtenido = numBinario.numeroBinario();
            Assert.AreEqual(valorEsperado, valorObtenido);
        }
    }
}

