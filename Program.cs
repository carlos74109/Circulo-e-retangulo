using Pasta.Entidades;
using Pasta.Entidades.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidades de figura: ");
            int qtdeFigura = int.Parse(Console.ReadLine()); 

            List<Shape> forma = new List<Shape>();

            for(int i = 0; i < qtdeFigura; i++)
            {
                Console.WriteLine("A figura é um retangulo ou circulo? (r/c): ");
                string leituraObjeto = Console.ReadLine();

                Console.WriteLine("Cor: (Black/Blue/Red)");
                Color cor = (Color)Enum.Parse(typeof(Color), Console.ReadLine());


                if (leituraObjeto == "r")
                {
                    string nome = "Retangulo: ";
                    Console.WriteLine("Digite a altura do retangulo: ");
                    double altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a largura do rentagulo: ");
                    double largura = double.Parse(Console.ReadLine());

                    forma.Add(new Retangulo(largura, altura, cor, nome));
                }else if(leituraObjeto == "c")
                {
                    string nome = "Circulo: ";
                    Console.WriteLine("Digite o raio do circulo: ");
                    double raio = double.Parse(Console.ReadLine());

                    forma.Add(new Circulo(raio, cor, nome));
                }
            }

            foreach(Shape shape in forma)
            {
                Console.WriteLine(shape.nome + shape.Area());
            }

        }
    }
}
