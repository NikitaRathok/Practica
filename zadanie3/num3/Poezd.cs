using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
     class Poezd
    {
        public string PunktNaz { get;  set; }
        public string NumberP { get;  set; }
        public DateTime Time { get;  set; }
        public int Index { get;  set; }

        public Poezd(int index,string punktNaz, string numberP,DateTime time)
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
            for (double i = 0; i < p1.Index; i++)
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
            for (double i = 0; i < p1.Index; i++)
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
            for (double i = 0; i < p1.Index; i++)
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
            for (double i = 0; i < p1.Index; i++)
            {
                if (p1 != p2)
                {
                    return false;
                }
                return false;
            }
            return true;
        }
        public string Info()
        {
           return $"\nИндекс поезд: {Index}"+
            $"\nПункт назначения: { PunktNaz}"+
            $"\nномер поезда: {NumberP}"+
            $"\nВремя отправления: {Time}";
        }


    }
}
