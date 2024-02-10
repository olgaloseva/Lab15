using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    interface ISeries
    {
        /// <summary>
        /// Метод устанавливает начальное значение последовательности
        /// </summary>
        /// <param name="x"></param>
        void SetStart(int x);

        /// <summary>
        /// Метод возвращает следующее значение последовательности
        /// </summary>
        /// <returns></returns>
        int GetNext();

        /// <summary>
        /// Метод сбрасывает последовательность на начальное значение
        /// </summary>
        void Reset();
    }
}
