using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasta.Entidades.Enuns;

namespace Pasta.Entidades
{
    internal class Retangulo : Shape
    {

        public double largura;
        public double altura;

        public Retangulo(double largura, double altura, Color cor, string nome) : base(cor, nome)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public sealed override double Area()
        {
            return largura * altura;
        }
    }
}
