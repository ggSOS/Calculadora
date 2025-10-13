using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal abstract class Calculadora
    {
        private static double Soma(double x, double y)
        {
            return x + y;
        }
        private static double Subtracao(double x, double y)
        {
            return x - y;
        }
        private static double Multiplicacao(double x, double y)
        {
            return x * y;
        }
        private static double? Divisao(double x, double y)
        {
            if (y == 0)
            {
                return null;
            }
            return x / y;
        }

        public static double? RealizarOperacao(string operacao, double x, double y)
        {
            if (operacao == "+")
            {
                return Calculadora.Soma(x, y);
            }
            if (operacao == "-")
            {
                return Calculadora.Subtracao(x, y);
            }
            if (operacao == "x")
            {
                return Calculadora.Multiplicacao(x, y);
            }
            if (operacao == "+")
            {
                return Calculadora.Divisao(x, y);
            }
            return null;
        }
    }
}
