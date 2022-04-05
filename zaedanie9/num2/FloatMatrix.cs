using System;

namespace num2
{


    public class FloatMatrix : IComparable
    {
        public double[,] matrix;
        int rows => matrix.GetLength(0);
        int colums => matrix.GetLength(1);
        int Length => matrix.Length;

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

        public FloatMatrix(int rows, int colums)
        {
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

        public int CompareTo(object obj)
        {
            return CompareTo(obj as FloatMatrix);
        }
        private int CompareTo(FloatMatrix other)
        {
            if (other == null)
                throw new ArgumentNullException();
            if (this == other)
            {
                return 0;
            }
            return Length > other.Length ? 1 : -1;
        }
        public void ZeroMatrix(int r) 
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] == 0)
                    { r = r + 1; }
                }
            }
            if (r == colums * rows)
            { Console.WriteLine("Матрица нулевая"); }
            else { Console.WriteLine("Матрица не нулевая"); }
        }
        public bool SymmetricalMatrix(bool a) 
        {
            if (colums == rows)
            {
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < matrix.GetLength(1); ++j)
                        if (matrix[i, j] != matrix[j, i])
                        {
                            a = false;
                            break;
                        }
                    if (!a) break;
                }
                return a;
            }
            else return false;
        }

        public void SquareMatrix() 
        {
            if (rows == colums)
            {
                Console.WriteLine("Матрица квадратная");
            }
            else Console.WriteLine("Матрица не квадратная");
        }
        public bool SingleMatrix() 
        {
            if (rows == colums)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (i == j && matrix[i, j] != 1)
                        {
                            return false;
                        }
                        else if (i != j && matrix[i, j] != 0)
                        { return false; }
                    }
                }
                return true;
            }
            return false;
        }
        public bool Diagonal(bool t) 
        {
            if (rows == colums)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (i != j)
                        {
                            if (matrix[i, j] == 0)
                            {
                                t = true;
                            }
                            else t = false;
                            break;
                        }
                    }
                }
            }
            return t;
        }

        public bool UpperTreangle()
        {
            if (rows == colums)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (matrix[i, j] != 0 && i > j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool LowerTreangle()
        {
            if (rows == colums)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (matrix[i, j] != 0 && i < j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
