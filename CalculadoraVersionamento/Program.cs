using System;
using System.Collections.Generic;

namespace CalculadoraVersionamento
{
    internal class Program
    {
        //1º Deve realizar operações de adição
        //2º Deve realizar operações de subtração
        //3º Deve realizar operações de multiplicação
        //4º Deve realizar operações de divisão
        //5º Deve visualizar operações realizadas

        static List<string> calculos = new List<string>();
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                OpcaoMenu();

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.ToUpper() == "S")
                    break;

                switch (opcao)
                {
                    case "1":
                        Adicao(calculos);
                        break;
                    case "2":
                        Subtracao(calculos);
                        break;
                    case "3":
                        Multiplicacao(calculos);
                        break;
                    case "4":
                        Divisao(calculos);
                        break;
                    case "5":
                        VisualizarOperacoes(calculos);
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada, pressione enter para voltar ao menu.");
                        Console.ReadKey();
                        break;
                }
                #endregion
            }
        }

        private static void ObterValores(out double primeiroNumero, out double segundoNumero)
        {
            Console.Write($"Digite o primeiro número: ");
            primeiroNumero =Convert.ToDouble(Console.ReadLine());
            Console.Write($"Digite o segundo número: ");
            segundoNumero =Convert.ToDouble(Console.ReadLine());
        }

        private static void VisualizarOperacoes(List<string> calculos)
        {
            Console.WriteLine("Visualizar histórico de operacões");

            foreach(var item in calculos)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void Divisao(List<string> calculos)
        {
            double primeiroValor;
            double segundoValor;

            ObterValores(out primeiroValor, out segundoValor);

            if (segundoValor == 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possível dividir por 0!");
                Console.ResetColor();

            }
            else
            {

                Console.WriteLine($"O resultado da operação de divisão é: {primeiroValor / segundoValor}");

                calculos.Add($"{primeiroValor} / {segundoValor} = {primeiroValor + segundoValor}");

            }

            Console.ReadKey();
        }

        private static void Multiplicacao(List<string> calculos)
        {
            Console.Clear();

            Console.WriteLine("Informe os valores para o calculo de multiplicação");

            double primeiroValor;
            double segundoValor;

            ObterValores(out primeiroValor, out segundoValor);

            double resultado = primeiroValor * segundoValor;

            string mensagem = $"Soma {primeiroValor} + {segundoValor} = {resultado}";

            Console.WriteLine(mensagem);

            calculos.Add(mensagem);

            Console.ReadKey();
        }

        private static void Subtracao(List<string> calculos)
        {
            double primeiroValor; 
            double segundoValor;

            ObterValores( out primeiroValor, out segundoValor);

            double valor = primeiroValor - segundoValor;                     

            string resultado = $"O Resultado da Subtração de {primeiroValor} - {segundoValor} deu = {valor} ";

            calculos.Add(resultado);

            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        private static void Adicao(List<string> calculos)
        {
            double primeiroValor;
            double segundoValor;

            ObterValores(out primeiroValor, out segundoValor);

            Console.WriteLine($"O resultado da operação de adição é: {primeiroValor + segundoValor}");

            calculos.Add($"{primeiroValor} + {segundoValor} = {primeiroValor + segundoValor}");

            Console.ReadKey();
        }

        private static void OpcaoMenu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara\n");

            Console.WriteLine("Tela Principal\n");

            Console.WriteLine("Digite 1 para realizar operações de Adição\n");

            Console.WriteLine("Digite 2 para realizar operações de Subtração\n");

            Console.WriteLine("Digite 3 para realizar operações de Multiplicação\n");

            Console.WriteLine("Digite 4 para realizar operações de Divisão\n");

            Console.WriteLine("Digite 5 para visualizar as operações feitas\n");

            Console.WriteLine("Digite S para sair\n");
        }
    }
}
