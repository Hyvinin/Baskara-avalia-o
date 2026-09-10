using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraApp
{
    public class Bhaskara
    {
        // Coeficientes da equação de segundo grau
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Construtor
        public Bhaskara(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("O coeficiente A não pode ser zero.");
            }

            A = a;
            B = b;
            C = c;
        }

        // Calculando o valor de Delta
        private double CalcularDelta()
        {
            return (B * B) - (4 * A * C);
        }

        // Verificando se a equação possui raízes reais
        public bool TemRaizesReais()
        {
            double delta = CalcularDelta();

            return delta >= 0;
        }

        // Calculando as raízes da equação
        public (double?, double?) CalcularRaizes()
        {
            if (!TemRaizesReais())
            {
                // Não possui raízes reais
                return (null, null);
            }

            double delta = CalcularDelta();
            double raizDelta = Math.Sqrt(delta);

            // Fórmula de Bhaskara
            double x1 = (-B + raizDelta) / (2 * A);
            double x2 = (-B - raizDelta) / (2 * A);

            return (x1, x2);
        }
    }
}