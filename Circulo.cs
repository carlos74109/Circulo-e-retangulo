using Pasta.Entidades.Enuns;
using System;

namespace Pasta.Entidades
{
    internal class Circulo : Shape
    {

        public double raio;

        public Circulo (double raio, Color cor, string nome) : base(cor, nome)
        {
            this.raio = raio;
        }

        public sealed override double Area()
        {
            return Math.PI * raio * raio;
        }
    }
}
