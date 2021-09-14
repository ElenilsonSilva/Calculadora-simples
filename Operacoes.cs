using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Operacoes
    {
        public string Sum(int value1, int value2)
        {
            return $"{value1} + {value2} = {value1 + value2}";
        }

        public string Subtraction(int value1, int value2)
        {
            return $"{value1} - {value2} = {value1 - value2}";
        }

        public string Division(double value1, double value2) 
        {
            return $"{value1} / {value2} = {value1 / value2}";
        }

        public string Multiplication(int value1, int value2)
        {
            return $"{value1} * {value2} = {value1 * value2}";
        }
        
        
    }
}
