using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Disor
{
    public partial class Form1 : Form
    {
        private Fibonacci fibonacci;
        private NumeroBinario numeroBinario;
        private NumeroHexadecimal numeroHexadecimal;
        private NumeroCapicua numeroCapicua;
        private NumeroFeliz numeroFeliz;
        private NumeroEspañol numeroEspañol;
        private NumeroPadovan numeroPadovan;
        private NumeroSuerte numeroSuerte;
        private NumeroUlam numeroUlam;
        public Form1()
        {
            InitializeComponent();
            fibonacci = new Fibonacci();
            numeroBinario = new NumeroBinario();
            numeroHexadecimal = new NumeroHexadecimal();
            numeroCapicua = new NumeroCapicua();
            numeroFeliz = new NumeroFeliz();
            numeroEspañol = new NumeroEspañol();
            numeroPadovan = new NumeroPadovan();
            numeroSuerte = new NumeroSuerte();
            numeroUlam = new NumeroUlam();
            btnDecrementar.Enabled = false;
        }

        private void btnFibonacciIncrementar_Click(object sender, EventArgs e)
        {
            fibonacci.incrementar();
            if (fibonacci.numeroFibonacci() > 0)
            {
                btnDecrementar.Enabled = true;
            }
            numeroCapicua.esCapicua(fibonacci.numeroFibonacci());
            txtFCapicua.Text = numeroCapicua.resultadoCapicua();
            txtFDecimal.Text = Convert.ToString(fibonacci.numeroFibonacci());
            numeroBinario.decimalABinario(fibonacci.numeroFibonacci());
            txtFBinario.Text = numeroBinario.numeroBinario();
            numeroHexadecimal.decimalAHexadecimal(fibonacci.numeroFibonacci());
            txtFHexadecimal.Text = numeroHexadecimal.numeroHexadecimal();
        }

        private void btnSuerteIncrementar_Click(object sender, EventArgs e)
        {

        }

        private void btnPadovanIncrementar_Click(object sender, EventArgs e)
        {
            numeroPadovan.incrementar();
            if (numeroPadovan.numeroPadovan() > 0)
            {
                btnDecrementar.Enabled = true;
            }
            numeroCapicua.esCapicua(numeroPadovan.numeroPadovan());
            txtPadovanCapicua.Text = numeroCapicua.resultadoCapicua();
            txtPDecimal.Text = Convert.ToString(numeroPadovan.numeroPadovan());
            numeroBinario.decimalABinario(numeroPadovan.numeroPadovan());
            txtPBinario.Text = numeroBinario.numeroBinario();
            numeroHexadecimal.decimalAHexadecimal(numeroPadovan.numeroPadovan());
            txtPHexadecimal.Text = numeroHexadecimal.numeroHexadecimal();
        }

        private void btnUlamIncrementar_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrementar_Click(object sender, EventArgs e)
        {
            if (fibonacci.numeroFibonacci() > 0)
            {
                fibonacci.decrementar();
                numeroCapicua.esCapicua(fibonacci.numeroFibonacci());
                txtFCapicua.Text = numeroCapicua.resultadoCapicua();
                txtFDecimal.Text = Convert.ToString(fibonacci.numeroFibonacci());
                numeroBinario.decimalABinario(fibonacci.numeroFibonacci());
                txtFBinario.Text = numeroBinario.numeroBinario();
                numeroHexadecimal.decimalAHexadecimal(fibonacci.numeroFibonacci());
                txtFHexadecimal.Text = numeroHexadecimal.numeroHexadecimal();
            }
            if(numeroPadovan.numeroPadovan() >= 1 )
            {
                numeroPadovan.decrementar();
                numeroCapicua.esCapicua(numeroPadovan.numeroPadovan());
                txtPadovanCapicua.Text = numeroCapicua.resultadoCapicua();
                txtPDecimal.Text = Convert.ToString(numeroPadovan.numeroPadovan());
                numeroBinario.decimalABinario(numeroPadovan.numeroPadovan());
                txtPBinario.Text = numeroBinario.numeroBinario();
                numeroHexadecimal.decimalAHexadecimal(numeroPadovan.numeroPadovan());
                txtPHexadecimal.Text = numeroHexadecimal.numeroHexadecimal();
            }
        }
    }
}
