using System;

namespace num1
{
    internal partial class Program
    {
        public class GumballMachine
        {

            IState soldOutState;
            IState noQuarterState;
            IState hasQuarterState;
            IState soldState;

            IState state;
            int count = 0;

           
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

            
            public void TurnCrank()
            {
                state.TurnCrank();
                state.Dispense();
            }

            

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
        }
    }