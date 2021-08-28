using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Menu : Operacoes
    {
        public const int Divisao = 3;
        public const int Adicao = 1;
        public const int Multiplicacao = 4;
        public const int Subtracao = 2;

       
        public void OpcoesMenu()
        {
            int escolha;
            Console.WriteLine("BEM VINDO A CALCULADORA");
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
                    Console.WriteLine(Sum(n1, n2));
           
                    break;
                case Subtracao:
                    Console.WriteLine(Subtraction(n1, n2));
                    
                    break;
                case Divisao:
                    Console.WriteLine(Division(ParseFloat(n1), ParseFloat(n2)));
                    
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
