using System;

namespace num2
{

    public class FloatMatrix
    {
        public double[,] matrix;
        int rows { get; set; }
        int colums;

        public static bool operator ==(FloatMatrix current, FloatMatrix matrix)
        {
            if (current.rows!=matrix.rows || current.colums!=matrix.colums)
            {
                return false;
            }
            for (int i = 0; i <current.rows; i++)
            {
                for (int j = 0; j < current.colums; j++)
                {
                    if (current[i,j]!=matrix[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(FloatMatrix current,FloatMatrix matrix)
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


        public FloatMatrix(int rows, int colums)
        {
            this.rows = rows;
            this.colums = colums;

            matrix = new double[rows, colums];

        }
        public double this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
        }
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
