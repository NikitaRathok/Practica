using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace num2
{
    internal partial class Program
    {
        public static FloatMatrix CreatMat(int n,int m)
        {
           
            FloatMatrix matrix = new FloatMatrix(n,m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
        public static FloatMatrix Print(int n, int m)
        {
            FloatMatrix matrix = CreatMat(n,m);

            Console.WriteLine("Матрица :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Заполните матрицу");
            FloatMatrix fm = new FloatMatrix(n,m);
            Console.Write("Введите элемент  : ");
            CreatMat(n,m);
            Print(n,m);
            fm.CompareTo(fm);
            
            int r = 0;
            fm.ZeroMatrix(r);

            if (fm.IsSymmetricalMatrix() == false)
            {
                Console.WriteLine("Матрица не симметричная");
            }
            else Console.WriteLine("Матрица симметричная");
            if(fm.IsSquareMatrix() == true)
            {
                Console.WriteLine("Квадратная матрица");
            }
            else
            {
                Console.WriteLine("Не квадратная матрица");
            }
            

            if (fm.IsSingleMatrix())
            {
                Console.WriteLine("Матрица единичная");
            }
            else Console.WriteLine("Матрица не единичная");

            if (fm.IsDiagonal() == true)
            {
                Console.WriteLine("Матрица диагональная");
            }
            else Console.WriteLine("Матрица не диагональная");

            if (fm.IsUpperTreangle())
            {
                Console.WriteLine("Матрица верхняя треугольная ");
            }
            else Console.WriteLine("Матрица не верхняя треугольная ");

            if (fm.IsLowerTreangle())
            {
                Console.WriteLine("Матрица нижняя треугольная ");
            }
            else Console.WriteLine("Матрица не нижняя треугольная ");
            Console.WriteLine(fm.matrix[0, 0]);
        }
    }
}
