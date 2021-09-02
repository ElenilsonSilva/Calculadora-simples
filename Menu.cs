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
            Console.WriteLine("BEM VINDO A CALCULADORA");
            Console.WriteLine("1 - Fazer Operação");
            Console.WriteLine("2 - Exibir Histórico");
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    OpcoesMenu();
                    break;
                case "2":
                    Console.WriteLine("Lista");
                    foreach(var item in historico)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválido");
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
                Console.WriteLine("Escolha a operação");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
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
                    Console.WriteLine(Sum(n1, n2));
                    BoasVindas();
                    break;
                case Subtracao:
                    Console.WriteLine(Subtraction(n1, n2));                   
                    break;
                case Divisao:
                    Console.WriteLine(Division((float)n1, (float)n2));                   
                    break;
                case Multiplicacao:
                    Console.WriteLine(Multiplication(n1, n2));                 
                    break;
                default:
                    break;
            }
        }
        

    }
}
