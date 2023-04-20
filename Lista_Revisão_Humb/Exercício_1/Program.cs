using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QuantidadeItens;
            float PrecoUnitario;
            float PrecoTotal;

            Console.Write("Quantidade de itens: ");
            QuantidadeItens = int.Parse(Console.ReadLine());

            Console.Write("Preço unitário: ");
            PrecoUnitario = float.Parse(Console.ReadLine());

            PrecoTotal = QuantidadeItens * PrecoUnitario;

            Console.WriteLine("Preço total: " + PrecoTotal);
            Console.ReadLine();
        }
    }
}
