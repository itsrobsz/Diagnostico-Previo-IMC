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

            // Validação dos dados digitados pelo usuário 
            while (aceito.ToLower() != "sim" && aceito.ToLower() != "não")
            {
                Console.WriteLine("Precisamos de uma confirmação válida. Por favor, digite SIM para que possamos continuar ou NÃO caso queira sair.");
                aceito = Console.ReadLine();
            }

            if (aceito.ToLower() == "sim")
            {
                Console.WriteLine("Perfeito! Agora vamos dar continuidade ao programa.");
                Console.WriteLine("Pressione ENTER para prosseguir.");
                Console.ReadLine();
            }

            else if (aceito.ToLower() == "não")
            {
                Console.WriteLine("Certo! Entendemos que você NÃO queira prosseguir. Até uma próxima e siga se cuidando!");
                Environment.Exit(0);
            }

            // Declaração das variáveis
            string nome;
            string sexo;
            int idade;
            double altura;
            double peso;
            double imc;


            // Solicitação do preenchimento da variável nome pelo usuário
            Console.WriteLine("Agora, digite seu nome: \n(Exemplo: José da Silva)");
            nome = Console.ReadLine();



            // Solicitação do preenchimento da variável sexo pelo usuário
            Console.WriteLine("Digite seu sexo: (M ou F)");
            sexo = Console.ReadLine();

            while (sexo.ToUpper() != "M" && sexo.ToUpper() != "F")
            {
                Console.WriteLine("Sexo não encontrado! Por favor, insira o dado conforme especificado entre parênteses.");
                sexo = Console.ReadLine();
            }

            if (sexo.ToUpper() == "M")
            {
                sexo = "Masculino";
            }

            if (sexo.ToUpper() == "F")
            {
                sexo = "Feminino";
            }


            // Solicitação do preenchimento da variável idade pelo usuário
            Console.WriteLine("Nos informe sua idade: ");
            var idade1 = (Console.ReadLine());

            var verificacaoIdade = int.TryParse(idade1, out idade);

            // Validações e definição de limites para idade
            while (verificacaoIdade == false)
            {
                Console.WriteLine("Por favor, digite uma idade. Se tiver tentando inserir letras, coloque números.");
                Console.WriteLine("Nos informe sua idade: ");
                idade1 = (Console.ReadLine());
                verificacaoIdade = int.TryParse(idade1, out idade);
            }

            while (idade < 0)
            {
                Console.WriteLine("Não existe idade negativa. Tente novamente!");
                idade = int.Parse(Console.ReadLine());
            }

            while (idade > 119)
            {
                Console.WriteLine("A pessoa mais velha viveu até os 119 anos. Insira uma idade válida!");
                idade = int.Parse(Console.ReadLine());
            }


            // Solicitação do preenchimento da variável altura pelo usuário
            Console.WriteLine("Insira sua altura (em metros): ");
            Console.WriteLine("Um lembrete: Utilize vírgula, não ponto. ");
            var altura1 = (Console.ReadLine());


            // Uso do TryParse para evitar erro de exceções
            var verificacaoAltura = double.TryParse(altura1, out altura);

            while (verificacaoAltura == false)
            {
                Console.WriteLine("Por favor, digite uma altura para prosseguir.\n Digite números, não letras.");
                Console.WriteLine("(Lembre-se: em metros e separada por vírgula.)");
                altura1 = (Console.ReadLine());
                verificacaoAltura = double.TryParse(altura1, out altura);
            }

            // Validação e limites de altura
            while (altura == 0)
            {
                Console.WriteLine("Você deve medir alguma coisa, no mínimo!");
                Console.WriteLine("Verifique o que foi digitado e tente novamente.");
                altura = double.Parse(Console.ReadLine());
            }

            while (altura < 0)
            {
                Console.WriteLine("Da mesma forma que não existe idade negativa, não existe altura negativa.");
                Console.WriteLine("Tente novamente! (Exemplo: 1,78)");
                altura = double.Parse(Console.ReadLine());
            }

            while (altura > 2.80)
            {
                Console.WriteLine("A pessoa mais alta a existir na história possui 2,51 metros de altura.");
                Console.WriteLine("Por favor, insira uma altura dentro dessa média. Se já for o caso, separá-la por vírgula.");
                altura = double.Parse(Console.ReadLine());
            }

            
            // Solicitação do preenchimento da variável peso pelo usuário
            Console.WriteLine("Digite seu peso, em kg: ");
            var peso1 = (Console.ReadLine());


            // Utilização do TryParse para evitar erros de exceções
            var verificacaoPeso = double.TryParse(peso1, out peso);


            while (verificacaoPeso == false)
            {
                Console.WriteLine("Impossível captar peso em letras.");
                Console.WriteLine("Por favor, digite seu peso. Lembre-se de separá-lo por vírgula e não ponto!");
                peso1 = (Console.ReadLine());
                verificacaoPeso = double.TryParse(peso1, out peso);
            }


            // Validações e definições de limites para peso
            while (peso == 0)
            {
                Console.WriteLine("Todos já nascemos com algum peso. Verifique o que foi digitado e tente novamente!");
                peso = double.Parse(Console.ReadLine());
            }

            while (peso < 0)
            {
                Console.WriteLine("Na casa dos negativos... Não podemos prosseguir!");
                Console.WriteLine("Digite novamente um peso (que seja positivo!): ");
                peso = double.Parse(Console.ReadLine());
            }

            while (peso > 595)
            {
                Console.WriteLine("A pessoa mais pesada a viver no mundo tinha 595kg. Digite um peso dentro desse parâmetro.");
                Console.WriteLine("Digite um peso: ");
                peso = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pressione ENTER novamente para gerarmos o diagnóstico.");
            Console.ReadLine();


            /// <summary>
            /// Função que verifica a categoria a qual uma pessoa pertence de acordo com a sua idade
            /// Recebe um argumento do tipo inteiro
            /// </summary>
            /// <param name="x"></param>
            /// <returns>Retorna uma string após a verificação</returns>
            static string VerificarCategoria(int x)
            {
                if (x < 12)
                {
                    return "Infantil";
                }

                else if (x >= 12 && x <= 20)
                {
                    return "Juvenil";
                }

                else if (x >= 21 && x <= 65)
                {
                    return "Adulto";
                }

                else
                {
                    return "Idoso";
                }
            }

            // Cálculo do imc para futuras verificações em funções
            imc = peso / (altura * altura);


            /// <summary>
            /// Função que verifica os riscos a qual uma pessoa pertence de acordo com o IMC calculado
            /// Recebe um argumento do tipo double
            /// </summary>
            /// <param name="y"></param>
            /// <returns>Retorna uma string após a verificação</returns>
            static string VerificarRiscos(double y)
            {
                if (y < 20)
                {
                    return "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
                }

                else if (y >= 20 && y <= 24)
                {
                    return "Seu peso está ideal para suas referências.";
                }

                else if (y >= 25 && y <= 29)
                {
                    return "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                }

                else if (y >= 30 && y <= 35)
                {
                    return "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                }

                else
                {
                    return "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
                }
            }


            /// <summary>
            /// Função que verifica as recomendações iniciais que uma pessoa deve seguir, de acordo com o IMC calculado
            /// Recebe um argumento do tipo double
            /// </summary>
            /// <param name="z"></param>
            /// <returns>Retorna uma string após a verificação</returns>
            static string VerificarRecomendacoes(double z)
            {
                if (z < 20)
                {
                    return "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional.";
                }

                else if (z >= 20 && z <= 24)
                {
                    return "Mantenha uma dieta saudável e faça seus exames periódicos.";
                }

                else if (z >= 25 && z <= 29)
                {
                    return "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante.";
                }

                else if (z >= 30 && z <= 35)
                {
                    return "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista (endócrino).";
                }

                else
                {
                    return "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).";
                }
            }


            // Exibição do Diagnóstico de acordo com os dados coletados e cálculos feitos 
            Console.WriteLine("Aqui está o seu Diagnóstico Prévio!");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Categoria: " + VerificarCategoria(idade));
            Console.WriteLine();
            Console.WriteLine("IMC Desejável: Entre 20 e 24");
            Console.WriteLine();
            Console.WriteLine("Resultado IMC: " + Math.Round(imc, 2));
            Console.WriteLine();
            Console.WriteLine("Riscos: " + VerificarRiscos(imc));
            Console.WriteLine();
            Console.WriteLine("Recomendação Inicial: " + VerificarRecomendacoes(imc));
        }
    }
}
