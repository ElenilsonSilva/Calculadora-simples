using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Menu : Operacoes
    {
        List<string> historico = new List<string>();
        public const int Divisao = 3;
        public const int Adicao = 1;
        public const int Multiplicacao = 4;
        public const int Subtracao = 2;

       public void BoasVindas()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("|          BEM VINDO A CALCULADORA         |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("|           1 - Fazer Operação             |");
            Console.WriteLine("|           2 - Exibir Histórico           |");
            Console.WriteLine("|           3 - Sair                       |");
            Console.WriteLine("|------------------------------------------|");
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    OpcoesMenu();
                    break;
                case "2":
                    ExibirHistorico();
                    break;
                case "3":
                    Console.WriteLine("\n            Valeu, até a próxima. :) \n");
                    break;
            }
        }
        public void OpcoesMenu()
        {
            int escolha;
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Int32.Parse(Console.ReadLine());
            
            do
            {
                Console.WriteLine("|------------------------------------------|");
                Console.WriteLine("|           ESCOLHA A OPERAÇÃO             |");
                Console.WriteLine("|              1 - Adição                  |");
                Console.WriteLine("|              2 - Subtração               |");
                Console.WriteLine("|              3 - Divisão                 |");
                Console.WriteLine("|              4 - Multiplicação           |");
                Console.WriteLine("|------------------------------------------|");
                escolha = Int32.Parse(Console.ReadLine());
           

            } while (escolha < 1 || escolha > 4);
            this.Escolha(escolha, numero1, numero2);
            
            
        }      
        public void Escolha(int escolha, int n1, int n2)
        {   
            switch(escolha)
            {
                case 1:
                    historico.Add(Sum(n1, n2));
                    Console.WriteLine($"\nO resultado da soma de {Sum(n1, n2)}\n");
                    BoasVindas();
                    break;
                case Subtracao:
                    historico.Add(Subtraction(n1, n2));
                    Console.WriteLine($"\nO resultado da subtração de {Subtraction(n1, n2)}\n");
                    BoasVindas();
                    break;
                case Divisao:
                    historico.Add(Division(n1, n2));
                    Console.WriteLine($"\nO resultado da divisão de {Division((float)n1, (float)n2)}\n");
                    BoasVindas();
                    break;
                case Multiplicacao:
                    historico.Add(Multiplication(n1, n2));
                    Console.WriteLine($"\nO resultado da multiplicação de {Multiplication(n1, n2)}\n");
                    BoasVindas();
                    break;
                default:
                    break;
            }
        }
        public void ExibirHistorico()
        {
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("|          Histórico de Operações          |");
            Console.WriteLine("|------------------------------------------|");
            foreach (var item in historico)
            {
                Console.WriteLine("   "+item+"           ");
                Console.WriteLine("|------------------------------------------|");

            }
        }

    }
}
