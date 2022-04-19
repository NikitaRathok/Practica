using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        public interface IState
        {
            void InsertQuarter();
            void EjectQuarter();
            void TurnCrank();
            void Dispense();

        }

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

        public class GumballMachine
        {

            IState soldOutState;//распродано нет шариков
            IState noQuarterState;//нет монеты
            IState hasQuarterState;//есть монета
            IState soldState;//продать шарик

            IState state;// soldOutState;//исходное состояние
            int count = 0;

            //конструктор получает исходное количество шариков
            public GumballMachine(int numberGumballs)
            {
                soldOutState = new SoldOutState(this);
                noQuarterState = new NoQuarterState(this);
                hasQuarterState = new HasQuarterState(this);
                soldState = new SoldState(this);

                state = soldOutState;

                this.count = numberGumballs;
                if (count > 0)
                {
                    state = noQuarterState;
                }
            }

            public void InsertQuarter()
            {
                state.InsertQuarter();
            }

            public void EjectQuarter()
            {
                state.EjectQuarter();
            }

            //Крутим рычаг выдачи жевательных шариков
            public void TurnCrank()
            {
                state.TurnCrank();
                state.Dispense();
            }

            //метод вызова выдачи шариков

            public override string ToString()
            {
                return "Число жевательных резинок: " + count;
            }

            internal IState GetHasQuarterState()
            {
                return hasQuarterState;
            }

            internal void SetState(IState state)
            {
                this.state = state;
            }

            public void ReleaseBall()
            {
                Console.WriteLine("Вам выдали жевательный шарик");
                if (count != 0)
                {
                    count--;
                }
            }

            internal IState GetNoQuarterState()
            {
                return noQuarterState;
            }

            internal IState GetSoldState()
            {
                return soldState;
            }

            internal int GetCount()
            {
                return count;
            }

            internal IState GetSoldOutState()
            {
                return soldOutState;
            }
        }
       
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