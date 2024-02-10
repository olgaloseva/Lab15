using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    //Разработать интерфейс ISeries генерации ряда чисел.Интерфейс содержит следующие элементы:
    //метод void SetStart(int x) - устанавливает начальное значение
    //метод int GetNext() - возвращает следующее число ряда
    //метод void Reset() - выполняет сброс к начальному значению
    //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
    //В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();    //арифметическая прогрессия, определение начального значения и шага
            arith.SetStart(1);
            arith.SetStep(3);
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            arith.Reset();                                         //сброс последовательности
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            Console.WriteLine();


            GeomProgression geom = new GeomProgression();           //геометрическая прогрессия, определение начального значения и шага
            geom.SetStart(1);
            geom.SetStep(3);
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            geom.Reset();                                            //сброс последовательности
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.ReadKey();
        }
    }
}
