using System;

namespace num1
{
    internal partial class Program
    {
        public class SoldOutState : IState
        {
            private GumballMachine gumballMachine;

            public SoldOutState(GumballMachine gumballMachine)
            {
                this.gumballMachine = gumballMachine;
            }

            public void Dispense()
            {
                Console.WriteLine("Нет жевательного шарика");
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Вы не можете забрать монету, так как еще ее не вставили");
            }

            public void InsertQuarter()
            {
                Console.WriteLine("В машине отсутствуюй жевательные шарики");
            }

            public void TurnCrank()
            {
                Console.WriteLine("Вы повернули рычаг, но отсутствуют жевательные шарики");
            }
            public override string ToString()
            {
                return "Распродано";
            }
        }
        }
    }