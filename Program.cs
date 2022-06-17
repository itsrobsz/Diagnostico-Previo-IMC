using System;

namespace Desafio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Apresentação do Programa
            Console.WriteLine("Bem vindo(a) ao programa de Diagnóstico Prévio!");
            Console.WriteLine("Precisaremos de alguns dados para podermos realizar o cálculo, tudo bem? (SIM OU NÃO)");
            string aceito = Console.ReadLine();

            //Validação dos dados digitados pelo usuário
            while(aceito.ToLower() != "sim" && aceito.ToLower() != "não")
            {
                Console.WriteLine("Precisamos de uma confirmação válida. Por favor, digite SIM para que possamos continuar ou NÃO caso queira sair.");
                aceito = Console.ReadLine();
            }

            if (aceito.ToLower() == "sim")
            {
                Console.WriteLine("Perfeito! Agora vamos dar continuidade ao programa.");
            }

            else if (aceito.ToLower() == "não")
            {
                Console.WriteLine("Entendemos que você NÃO queira prosseguir. Até uma próxima e siga se cuidando!");
            }

        }
    }
}
