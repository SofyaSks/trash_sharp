//пример 1 

/*using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Демонстрация System.GC");
            WriteLine($"Максимальное поколение: { GC.MaxGeneration}");
            GarbageHelper hlp = new GarbageHelper();
            WriteLine($"Поколение объекта: { GC.GetGeneration(hlp)}");
            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
            hlp.MakeGarbage();
            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
            GC.Collect(0);
            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
            WriteLine($"Поколение объекта: { GC.GetGeneration(hlp)}");
            GC.Collect();
            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
            WriteLine($"Поколение объекта:{ GC.GetGeneration(hlp)}");
        }
    }
    class GarbageHelper
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person();
            }
        }
        class Person
        {
            string _name;
            string _surname;
            byte _age;
        }
    }
}*/


using System;
using static System.Console;
namespace GCGenerationExample
{
    /*class Program
    {
        static void Main(string[] args)
        {

            Garbage g1 = new Garbage();
            Garbage g2 = new Garbage();
            Garbage g3 = new Garbage();
            Console.WriteLine("Номер поколения g1 : {0}", GC.GetGeneration(g1));
            Console.WriteLine("Номер поколения g2 : {0}", GC.GetGeneration(g2));
            Console.WriteLine("Номер поколения g3 : {0}", GC.GetGeneration(g3));
            Console.WriteLine("Количество занятой памяти " + "До сбора мусора: {0} байт", GC.GetTotalMemory(false));

            GC.Collect(0);
            Console.WriteLine("Количество занятой памяти " + "после сбора мусора: {0} байт", GC.GetTotalMemory(false));
            Console.WriteLine("Номер поколения g2 : {0}", GC.GetGeneration(g2));
            Console.WriteLine("Номер поколения g3 : {0}", GC.GetGeneration(g3));

            Console.WriteLine("Количнство занятой памяти " + "До сбора мусора: {0} байт", GC.GetTotalMemory(false));
            GC.Collect(1);
            Console.WriteLine("Номер поколения g3 : {0}", GC.GetGeneration(g3));
            Console.WriteLine("Количнство занятой памяти " + "До сбора мусора: {0} байт", GC.GetTotalMemory(false));
            GC.Collect(2);
            Console.WriteLine("Количнство занятой памяти " + "после сбора мусора: {0} байт", GC.GetTotalMemory(false));
            Console.WriteLine("Номер поколения g3 : {0}", GC.GetGeneration(g3));

        }
    }
    class Garbage
    {
        private int[] _garbage = null;
        public Garbage()
        {
            Random rnd = new Random();
            this._garbage = new int[rnd.Next(1000, 10000)];
            for (int i = 0; i < this._garbage.Length; i++)
            {
                this._garbage[i] = rnd.Next();
            }
        }


    }*/

    /*class FinalizeObject
    {
        public int id { get; set; }

        public FinalizeObject(int id)
        {
            this.id = id;
        }

        // Создадим специальный деструктор
        ~FinalizeObject()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Объект №{0} уничтожен", id);
            Console.Beep();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
            // После того как будет нажата клавиша Enter (выход из программы)
            // все последующие объекты будут уничтожены

            FinalizeObject[] obj = new FinalizeObject[15];
            for (int i = 0; i < 15; i++)
                obj[i] = new FinalizeObject(i);
        }
    }*/

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class DisposeEx : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Очистка");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DisposeEx de = new DisposeEx();
            de.Dispose();
        }
    }

}
