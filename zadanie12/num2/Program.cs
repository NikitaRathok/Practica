using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        public delegate int MathOperations(int a, int b)
;        static void Main(string[] args)
        {
           Console.WriteLine("Сложение");
           MathOperations  OpAdd = (a, b) => a + b;
           Console.WriteLine(OpAdd(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
           Console.WriteLine("Вычетание");
           MathOperations OpSub = (a, b) => a - b;
           Console.WriteLine(OpSub(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
           Console.WriteLine("Умножение");
           MathOperations OpMul = (a, b) => a * b;
           Console.WriteLine(OpMul(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
           Console.WriteLine("Деление");
           MathOperations OpDiv = (a, b) => b == 0 ? 0 : a / b;
           Console.WriteLine(OpDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        }
    }
}
