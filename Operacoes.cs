using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Operacoes
    {
        public double ParseFloat(int value)
        {
            return Convert.ToDouble(value);
        }
        public string Sum(int value1, int value2)
        {
            return $"O resultado da soma é {value1 + value2}";
        }

        public string Subtraction(int value1, int value2)
        {
            return $" O resultado da subtração é {value1 - value2}";
        }

        public string Division(double value1, double value2) 
        {
            return $"O resultado da divisão é {value1 / value2}";
        }

        public string Multiplication(int value1, int value2)
        {
            return $"O resultado da multiplicação é {value1 * value2}";
        }
    }
}
