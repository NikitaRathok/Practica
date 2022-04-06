using System;

namespace num2
{


    public class FloatMatrix:IComparable
    {
        public double[,] matrix;
        int rows =>matrix.GetLength(0);
        int colums => matrix.GetLength(1);
        int Length => matrix.Length;

        public static bool operator ==(FloatMatrix current, FloatMatrix m)
        {
            if (current?.rows != m?.rows || current?.colums != m?.colums)
            {
                return false;
            }
            for (int i = 0; i < current.rows; i++)
            {
                for (int j = 0; j < current.colums; j++)
                {
                    if (current[i, j] != m[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(FloatMatrix current, FloatMatrix matrix)
        {
            if (current?.rows != matrix?.rows || current?.colums != matrix?.colums)
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
        public FloatMatrix()
        {

        }
        public double this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
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
        public bool IsSymmetricalMatrix() 
        {
            if (colums != rows)
            {
                return false;
                
            }
            else
            {
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < colums; ++j)
                        if (matrix[i, j] != matrix[j, i])
                        {
                            return false;

                        }
                }
            }
            return true;
        }

        public bool IsSquareMatrix() 
        {
            if (rows == colums)
            {
                return true;
            }
            else return false;
        }
        public bool IsSingleMatrix() 
        {
            if (rows != colums)
            {
            return false;
            }
            else
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
        }
        public bool IsDiagonal() 
        {
            if (rows != colums)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (i != j)
                        {
                            if (matrix[i, j] == 0)
                            {
                                return true;
                            }
                            else return false;

                        }
                    }
                }
            }
            return true;
            
        }

        public bool IsUpperTreangle()
        {
            if (rows != colums)
            {
            return false;
                
            }
            else
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
            
        }
        public bool IsLowerTreangle()
        {
            if (rows != colums)
            {
                
            return false;
            }
            else
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
           
        }
    }
}
