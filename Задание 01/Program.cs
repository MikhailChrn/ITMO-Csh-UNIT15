using System;

namespace Задание_01

/*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
метод void setStart(int x) - устанавливает начальное значение
метод int getNext() - возвращает следующее число ряда
метод void reset() - выполняет сброс к начальному значению

Разработать классы ArithProgression и GeomProgression,
которые реализуют интерфейс ISeries. В классах реализовать методы интерфейса в соответствии
с логикой арифметической и геометрической прогрессии соответственно.
 */
{
    public interface ISeries //Объявляем интерфейс генерации ряда чисел
    {
        void setStart(int a, int d); //Объявляем метод задающий начальное значение ряда чисел и постоянное значение
        int getNext(); //Объявлем функцию, возращающую последующее число ряда чисел
        void reset(); //Объявляем метод перезапускающий ряд чисел к начальному значению
    }

    class ArithProgression : ISeries //Реализуем интерфейс ряда чисел в виде класса арифметической прогрессии
    {
        int startSeries;
        int constantValue;
        int valSeries;

        public void setStart(int a, int d)
        {
            startSeries = a;
            valSeries = startSeries;
            constantValue = d;
        }
        public int getNext()
        {
            valSeries = valSeries + constantValue;
            return valSeries;
        }

        public void reset()
        {
            valSeries = startSeries;
        }
    }

    class GeomProgression : ISeries //Реализуем интерфейс ряда чисел в виде класса геометрической прогрессии
    {
        int startSeries;
        int constantValue;
        int valSeries;
        public void setStart(int a, int d)
        {
            startSeries = a;
            valSeries = startSeries;
            constantValue = d;
        }
        public int getNext()
        {
            valSeries = valSeries * constantValue;
            return valSeries;
        }

        public void reset()
        {
            valSeries = startSeries;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Создаём экземпляры арифметической и геометрической прогрессии
            ArithProgression AP1 = new ArithProgression();
            GeomProgression GP1 = new GeomProgression();
            //Задаём начальные значения числовых рядов
            AP1.setStart(1, 2);
            GP1.setStart(1, 2);
            
            //Выводим первые десять элементов числовых рядов
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}   {1}", AP1.getNext(), GP1.getNext());
            }

            for (int i = 0; i < 10; i++)
            {
                AP1.getNext();
                GP1.getNext();
            }

            Console.WriteLine();

            //Выводим 20...30 элементов числовых рядов
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}   {1}", AP1.getNext(), GP1.getNext());
            }
        }
    }
}
