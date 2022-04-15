using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4_3_
{
    class Vokzal
    {
        private Poezd[] poezda;

        public Vokzal()
        {


        }

        /// <summary>
        /// Получение всех поездов
        /// </summary>
        /// <returns>массив поездов</returns>
        public Poezd[] GetAllPoezda()
        {
            return poezda;
        }
        /// <summary>
        /// Добваление поезда в массив
        /// </summary>
        /// <param name="poezd">Новый поезд</param>
        public void Add(Poezd poezd)
        {
            if (poezda == null)
            {
                poezda = new Poezd[1];
            }
            else
            {
                Array.Resize(ref poezda, poezda.Length + 1);
            }

            poezda[poezda.Length - 1] = poezd;
        }
        /// <summary>
        /// Получение информации о поезде по указаному времени
        /// </summary>
        /// <param name="time">введённое время</param>
        /// <returns>поезд отправляющийся в указаное время</returns>
        public Poezd[] InfoTime(DateTime time)
        {
            //LINQ
            return poezda.Where(p => p.Time == time).ToArray();

        }
        /// <summary>
        /// Получение всех поездов которые отправляются из указаного города или в указаный город
        /// </summary>
        /// <param name="punkt">пункт назначения</param>
        /// <returns>массив поездов которые отправляются из указаного города или в указаный город</returns>
        public Poezd[] ShowEndPunct(string punkt)
        {
            return poezda.Where(p => p.PunktNaz == punkt).ToArray();
        }
        /// <summary>
        /// Получение всех поездов с указанмы индексом
        /// </summary>
        /// <param name="index">индекс поезда</param>
        /// <returns>Все поезда с указанным индексом </returns>
        public Poezd[] ShowIndex(int index)
        {
            return poezda.Where(p => p.Index == index).ToArray();
        }

    }
}
