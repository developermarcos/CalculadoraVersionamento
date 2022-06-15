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
            Console.WriteLine("Divisao");
            Console.ReadKey();
        }

        private static void Multiplicacao(List<string> calculos)
        {
            Console.WriteLine("Multiplicacao");
            Console.ReadKey();
        }

        private static void Subtracao(List<string> calculos)
        {
            Console.WriteLine("Subtração");
            Console.ReadKey();
        }

        private static void Adicao(List<string> calculos)
        {
            //double primeiroValor;
            //double segundoValor;

            //ObterValores(out primeiroValor, out segundoValor);

            Console.WriteLine("Adicao");
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
