using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
     class Poezd
    {
        public string PunktNaz { get; private set; }
        public string NumberP { get; private set; }
        public double Time { get; private set; }
        public int Index { get; private set; }

        public Poezd(int index,string punktNaz, string numberP,double time)
        {
            PunktNaz = punktNaz;
            NumberP = numberP;
            Time = time;
            Index = index;
        }
        public Poezd()
        {

        }
        public static bool operator >(Poezd p1, Poezd p2)
        {
            for (double i = 0; i < p1.Time; i++)
            {
                if (p1 > p2)
                {
                    return false;
                }
                return false;
            }
            return true;
        }
        public static bool operator <(Poezd p1, Poezd p2)
        {
            for (double i = 0; i < p1.Time; i++)
            {
                if (p1 < p2)
                {
                    return false;
                }
                return false;

            }
            return true;
        }
        public static bool operator ==(Poezd p1, Poezd p2)
        {
            for (double i = 0; i < p1.Time; i++)
            {
                if (p1 == p2)
                {
                    return true;
                }
                return true;
            }
            return false;

        }
        public static bool operator !=(Poezd p1, Poezd p2)
        {
            for (double i = 0; i < p1.Time; i++)
            {
                if (p1 != p2)
                {
                    return false;
                }
                return false;
            }
            return true;
        }


    }
}
