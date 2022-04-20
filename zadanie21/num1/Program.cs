using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal partial class Program
    {
       
            static void Main(string[] args)
            {
                GumballMachine gumballMachine = new GumballMachine(5);
                Console.WriteLine(gumballMachine);

                gumballMachine.TurnCrank();
                gumballMachine.TurnCrank();

                gumballMachine.InsertQuarter();
                gumballMachine.InsertQuarter();

                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();

                Console.WriteLine("\n" + gumballMachine + "\n");

                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();

                Console.WriteLine("\n" + gumballMachine + "\n");

                Console.ReadKey();
            }
        }
    }