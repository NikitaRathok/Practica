using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Заполните матрицу");

            FloatMatrix matrix = new FloatMatrix(n, m);
            FloatMatrix matrix2 = new FloatMatrix(n, m);
            if (matrix==matrix2)
            {
                Console.WriteLine("Equals");
            }

            matrix.CreatMat();
            matrix.Print();
            Console.WriteLine("===========");
            Console.WriteLine("Изменённая матрица");
            matrix.Swap();
            
        }
    }
}
