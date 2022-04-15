using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4_3_
{
    class Poezd
    {
        public string PunktNaz { get; set; }
        public string NumberP { get; set; }
        public DateTime Time { get; set; }
        public int Index { get; set; }

        /// <summary>
        /// Конструктор класса Poezd
        /// </summary>
        /// <param name="index">Индекс поезда</param>
        /// <param name="punktNaz">Пункт назначения</param>
        /// <param name="numberP">Номер поезда</param>
        /// <param name="time">время прибытия</param>
        public Poezd(int index, string punktNaz, string numberP, DateTime time)
        {
            PunktNaz = punktNaz;
            NumberP = numberP;
            Time = time;
            Index = index;
        }
        public Poezd()
        {

        }
        /// <summary>
        /// Переопределение оператора больше
        /// </summary>
        /// <param name="p1">Первый поезд</param>
        /// <param name="p2">Второй поезд</param>
        /// <returns>true если первый поезд имеет индекс больше чем 2</returns>
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
        /// <summary>
        /// Переопределение оператора меньше
        /// </summary>
        /// <param name="p1">Первый поезд</param>
        /// <param name="p2">Второй поезд</param>
        /// <returns>true если индекс первого позда меньше индекса второго поезда</returns>
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
        /// <summary>
        /// Переопределение оператора ровно
        /// </summary>
        /// <param name="p1">Первый поезд</param>
        /// <param name="p2">Второй поезд</param>
        /// <returns>true если индекс первого поезда равен индексу второго поезда</returns>
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
        /// <summary>
        /// Переопределение оператора не ровно
        /// </summary>
        /// <param name="p1">Первый поезд</param>
        /// <param name="p2">Второй поезда</param>
        /// <returns>true если индекс первого поезда не равен индексу второго поезда</returns>
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
        /// <summary>
        /// Метод возвращающий информацию о поезде
        /// </summary>
        /// <returns>Информация о поезде</returns>
        public string Info()
        {
            return $"\nИндекс поезд: {Index}" +
             $"\nПункт назначения: { PunktNaz}" +
             $"\nномер поезда: {NumberP}" +
             $"\nВремя отправления: {Time}";
        }
    }
}
