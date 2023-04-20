using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetorDeStrings = new string[5];
            int tamanhoMaiorString = 0;
            //Erro --> Declaração do int.MinValue ao invés do int.MaxValue || Correção: Declarar int.MaxValue
            int tamanhoMenorString = int.MaxValue;
            string maiorString = "";
            string menorString = "";

            Console.WriteLine("Digite as 5 strings:");
            //Erro --> FOREACH em uma estrutura de FOR || Correção --> Troca de FOREACH para FOR
            //Erro --> Na hora de percorrer o for tinha o -2  || Correção --> Retirar o -2 para percorrer as 5 posições
            for (int i = 0; i < vetorDeStrings.Length; i++)
            {
                Console.Write($"String {i + 1}: ");
                vetorDeStrings[i] = Console.ReadLine();
                if (vetorDeStrings[i].Length > tamanhoMaiorString)
                {
                    tamanhoMaiorString = vetorDeStrings[i].Length;
                    maiorString = vetorDeStrings[i];
                }
                //Erro --> Simbolo de comparação "?" || Correção --> Adicionar o sinal de menor! 
                if (vetorDeStrings[i].Length < tamanhoMenorString)
                {
                    tamanhoMenorString = vetorDeStrings[i].Length;
                    menorString = vetorDeStrings[i];
                }
            }
            //Erro --> Estava faltando ponto e virgula no Console.WriteLine || Correção --> Adicionar ponto e vírgula! 
            Console.WriteLine($"Maior string: {maiorString}, com {tamanhoMaiorString} caracteres");
            Console.WriteLine($"Menor string: {menorString}, com {tamanhoMenorString} caracteres");

            Console.ReadLine();
        }
    }
}
