using Pasta.Entidades.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta.Entidades
{
    abstract internal class Shape
    {
        public Color color;
        public string nome;
       

        public Shape(Color color, string nome)
        {
            this.color = color;
            this.nome = nome;
        }

        public abstract double Area();
        
    }
}
