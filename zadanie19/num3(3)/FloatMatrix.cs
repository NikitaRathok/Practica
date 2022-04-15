using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3_3_
{
    public class FloatMatrix
    {
        public double[,] matrix;
        int rows { get; set; }
        int colums;

        /// <summary>
        /// Переопределение оператора =
        /// </summary>
        /// <param name="current">Текущая матрица</param>
        /// <param name="matrix">Новая матрица</param>
        /// <returns>Если false то матрицы не ровны иначе они ровны</returns>
        public static bool operator ==(FloatMatrix current, FloatMatrix matrix)
        {
            if (current.rows != matrix.rows || current.colums != matrix.colums)
            {
                return false;
            }
            for (int i = 0; i < current.rows; i++)
            {
                for (int j = 0; j < current.colums; j++)
                {
                    if (current[i, j] != matrix[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Переопределение оператора не ровно
        /// </summary>
        /// <param name="current">Текущая матрица</param>
        /// <param name="matrix">Новая матрица</param>
        /// <returns>false если матрицы ровны иначе они не ровны</returns>
        public static bool operator !=(FloatMatrix current, FloatMatrix matrix)
        {
            if (current.rows != matrix.rows || current.colums != matrix.colums)
            {
                return true;
            }
            for (int i = 0; i < current.rows; i++)
            {
                for (int j = 0; j < current.colums; j++)
                {
                    if (current[i, j] != matrix[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Конструктор класс FloatMatrix
        /// </summary>
        /// <param name="rows">Значение строк</param>
        /// <param name="colums">Значение колонок</param>
        public FloatMatrix(int rows, int colums)
        {
            this.rows = rows;
            this.colums = colums;

            matrix = new double[rows, colums];

        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index1">индекс по строкам</param>
        /// <param name="index2">индекс по столбцам</param>
        /// <returns>значение обьекта находящегося в index1 - строке, index2 - столбце</returns>
        public double this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
        }
        /// <summary>
        /// Метод замены элементов
        /// </summary>
        public void Swap()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        matrix[i, j] = -matrix[i, j];

                    }
                    else if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Метод создания матрицы
        /// </summary>
        public void CreatMat()
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write("Введите элемент [{0},{1}] : ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
        /// <summary>
        /// Вывод матрицы
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Матрица :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
