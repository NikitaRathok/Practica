using System;

namespace num1
{
    internal partial class Program
    {
        public class NoQuarterState : IState
        {
            GumballMachine gumballMachine;

            public NoQuarterState(GumballMachine gumballMachine)
            {
                this.gumballMachine = gumballMachine;
            }

            public void Dispense()
            {
                Console.WriteLine("Сначала нужно заплатить");
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Вы забыли вставить монету");
            }

            public void InsertQuarter()
            {
                Console.WriteLine("Вы вставили монету");
                gumballMachine.SetState(gumballMachine.GetHasQuarterState());
            }

            public void TurnCrank()
            {
                Console.WriteLine("Вы повернули рычаг не вставив монету");
            }
        }
        }
    }