using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("Calculo da média semestral:");
            Console.Write("Digite a nota da primeira avaliação:");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda avaliação:");
            b = float.Parse(Console.ReadLine());

            c = (a+2*b)/3;

            Console.Write($"Para uma nota final de {c}, o aluno foi: ");

            if (c >= 5)
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
        }
    }
}
