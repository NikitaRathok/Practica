using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание папки");
            Console.WriteLine("Папка создана");
            Directory.CreateDirectory("New_folder");
        }
    }
}
