using System;

namespace num1
{
    internal partial class Program
    {
        public class SoldState : IState
        {
            private GumballMachine gumballMachine;

            public SoldState(GumballMachine gumballMachine)
            {
                this.gumballMachine = gumballMachine;
            }

            public void Dispense()
            {
                gumballMachine.ReleaseBall();
                if (gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Извените жевательные шарики закончились");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Извените, вы уже повернули рычаг");
            }

            public void InsertQuarter()
            {
                Console.WriteLine("Ожидайте сейчас мы выдадим вам жевательную резинку");
            }

            public void TurnCrank()
            {
                Console.WriteLine("Повернув повторно рычаг вы не получите жевательную резинку");
            }
        }
        }
    }