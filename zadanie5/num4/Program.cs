using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    internal class Program
    {
        
        public static void GetAllHumansInThreeFloor(int [,] home,int s)
        {
            for(int i =0;i<home.GetLength(1); i++)
            {
                s += home[i,3];
            }
            Console.WriteLine(s);
        }
        public static void GetAllHumansIfFiveFloor(int[,] home, int s1)
        {
            for (int i = 0; i < home.GetLength(1); i++)
            {
                s1 += home[5,i];
            }
            Console.WriteLine(s1);
        }


        static void Main(string[] args)
        {
            int floors = 12;
            int appart = 4;
            int[,] home = new int[floors, appart];
            int s = 0;
            int s1 = 0;
            Random rnd = new Random();
            for (int i = 0;i<floors;i++)
            {
                for(int j = 0;j<appart;j++)
                {
                    home[i, j] = rnd.Next(1, 9);
                    Console.Write(" "+home[i,j]);
                }
                Console.WriteLine();
            }
           
            GetAllHumansInThreeFloor(home, s);
            GetAllHumansIfFiveFloor(home, s1);

            if(s1>s)
            {
                Console.WriteLine("на 5 больше") ;
            }
            else
            {
                Console.WriteLine("На 3 больше");
            }
        }
    }
}
