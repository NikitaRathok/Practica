using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

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
            FloatMatrix fm = new FloatMatrix(n,m);
            
            fm.CreatMat();
            fm.Print();
            fm.CompareTo(fm);
            bool a = false;
            bool t = false;
            int r = 0;
            fm.ZeroMatrix(r);

            if (fm.SymmetricalMatrix(a) == false)
            {
                Console.WriteLine("Матрица не симметричная");
            }
            else Console.WriteLine("Матрица симметричная");

            fm.SquareMatrix();

            if (fm.SingleMatrix())
            {
                Console.WriteLine("Матрица единичная");
            }
            else Console.WriteLine("Матрица не единичная");

            if (fm.Diagonal(t) == true)
            {
                Console.WriteLine("Матрица диагональная");
            }
            else Console.WriteLine("Матрица не диагональная");

            if (fm.UpperTreangle())
            {
                Console.WriteLine("Матрица верхняя треугольная ");
            }
            else Console.WriteLine("Матрица не верхняя треугольная ");

            if (fm.LowerTreangle())
            {
                Console.WriteLine("Матрица нижняя треугольная ");
            }
            else Console.WriteLine("Матрица не нижняя треугольная ");
            Console.WriteLine(fm.matrix[0, 0]);
        }
    }
}
