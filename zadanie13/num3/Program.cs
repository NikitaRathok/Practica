using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static num3.Input;

namespace num3
{
    internal partial class Program
    {
            static void Main(string[] args)
            {
                MyInfo my = new MyInfo();
                Person person = new Person();

                my.Changed += person.Message;
                var name= String("Enter new name");
            
                my.OnChanged(name);
                Console.ReadLine();
            }

            
        
    }
}
