using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroEspañol
    {
        private String res;
        private double nro = 0;

        public void enLetras(int numeroDecimal)
        {
            string num = Convert.ToString(numeroDecimal);
            string dec = "";
            Int64 entero;
            int decimales;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                res = "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
        }

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            if (value == 1) Num2Text = "UNO";
            if (value == 2) Num2Text = "DOS";
            if (value == 3) Num2Text = "TRES";
            if (value == 4) Num2Text = "CUATRO";
            if (value == 5) Num2Text = "CINCO";
            if (value == 6) Num2Text = "SEIS";
            if (value == 7) Num2Text = "SIETE";
            if (value == 8) Num2Text = "OCHO";
            if (value == 9) Num2Text = "NUEVE";
            if (value == 10) Num2Text = "DIEZ";
            if (value == 11) Num2Text = "ONCE";
            if (value == 12) Num2Text = "DOCE";
            if (value == 13) Num2Text = "TRECE";
            if (value == 14) Num2Text = "CATORCE";
            if (value == 15) Num2Text = "QUINCE";
            if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            if (value == 20) Num2Text = "VEINTE";
            if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            if (value == 30) Num2Text = "TREINTA";
            if (value == 40) Num2Text = "CUARENTA";
            if (value == 50) Num2Text = "CINCUENTA";
            if (value == 60) Num2Text = "SESENTA";
            if (value == 70) Num2Text = "SETENTA";
            if (value == 80) Num2Text = "OCHENTA";
            if (value == 90) Num2Text = "NOVENTA";
            if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            if (value == 100) Num2Text = "CIEN";
            if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            if (value == 500) Num2Text = "QUINIENTOS";
            if (value == 700) Num2Text = "SETECIENTOS";
            if (value == 900) Num2Text = "NOVECIENTOS";
            if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            if (value == 1000) Num2Text = "MIL";
            if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            if (value == 1000000) Num2Text = "UN MILLON";
            if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            if (value == 1000000000000) Num2Text = "UN BILLON";
            if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            return Num2Text;
        }

        public String nombre()
        {
            return res;
        }
    }
}
