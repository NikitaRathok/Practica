using System;

namespace num1
{
    internal partial class Program
    {
        public class HasQuarterState : IState
        {
            private GumballMachine gumballMachine;

            public HasQuarterState(GumballMachine gumballMachine)
            {
                this.gumballMachine = gumballMachine;
            }

            public void Dispense()
            {
                Console.WriteLine("Ошибка, мы не можем выдать вам жевательную резинку");
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Возвращаем монету");
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }

            public void InsertQuarter()
            {
                Console.WriteLine("Вы не можете вставить еще одну монету");
            }

            public void TurnCrank()
            {
                Console.WriteLine("Вы повернули рычаг...");
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }
        }
    }