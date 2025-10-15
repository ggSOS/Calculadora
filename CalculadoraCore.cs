using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class CalculadoraCore
    {
        private double[] valores;
        private int index;
        public CalculadoraCore()
        {
            valores = new double[8];
            index = 0;
        }

        public bool AddValor(double valor)
        {
            if (index >= valores.Length)
            {
                return false;
            }
            valores[index] = valor;
            index++;
            return true;
        }

        public double Soma()
        {
            double valor = 0;

            foreach (double item in valores)
            {

                valor += item;
                Console.WriteLine(item);

            }
            return valor;
        }


        public double Subtracao()
        {
            double valor = 0;

            foreach (double item in valores)
            {

                valor -= item;

            }

            return valor;
        }


        public double Multiplicacao()
        {
            double valor = 1.0;

            for (int count = 0; count < index; count++)
            {
                valor *= valores[count];
            }
            return valor;
        }


        public double? Divisao()
        {
            double valor = 1.0;

            for (int count = 0; count < index; count++)
            {
                if (valores[count] == 0 && count > 0)
                {
                    return null;
                }
                valor /= valores[count];
            }

            return valor;
        }
    }
}
