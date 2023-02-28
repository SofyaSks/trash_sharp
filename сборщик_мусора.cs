//1  сборщик мусора
//Garbage Collector
//класс System.GC
//Collect() - метод принудительного запуска сборщика мусора
//String, Attribute, Exception, Delegate - автоматически

//пример 1 

//using System;
//using static System.Console;
//namespace SimpleProject
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Демонстрация System.GC");
//            WriteLine($"Максимальное поколение: { GC.MaxGeneration}");
//            GarbageHelper hlp = new GarbageHelper();
//            WriteLine($"Поколение объекта: { GC.GetGeneration(hlp)}");
//            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
//            hlp.MakeGarbage(); 
//            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
//            GC.Collect(0); 
//            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
//            WriteLine($"Поколение объекта: { GC.GetGeneration(hlp)}");
//            GC.Collect(); 
//            WriteLine($"Занято памяти(байт): { GC.GetTotalMemory(false)}");
//            WriteLine($"Поколение объекта:{ GC.GetGeneration(hlp)}");
//        }
//    }
//    class GarbageHelper
//    {
//        public void MakeGarbage()
//        {
//            for (int i = 0; i < 1000; i++)
//            {
//                Person p = new Person();
//            }
//        }
//        class Person
//        {
//            string _name;
//            string _surname;
//            byte _age;
//        }
//    }
//}

// пример 2 +
//using System;

//namespace GCExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Демонстрация System.GC");
//            Console.WriteLine("Максимальное поколение: {0}", GC.MaxGeneration);

//            GarbageHelper hlp = new GarbageHelper();
//            Console.WriteLine("Поколение объекта: {0}", GC.GetGeneration(hlp));
//            Console.WriteLine("Занято памяти (байт): {0}",
//                GC.GetTotalMemory(false));
//            hlp.MakeGarbage();
//            Console.WriteLine("Занято памяти (байт): {0}",
//                GC.GetTotalMemory(false));
//            GC.Collect(0);
//            Console.WriteLine("Занято памяти (байт): {0}",
//                GC.GetTotalMemory(false));
//            Console.WriteLine("Поколение объекта: {0}",
//                GC.GetGeneration(hlp));
//            GC.Collect();
//            Console.WriteLine("Занято памяти (байт): {0}",
//                GC.GetTotalMemory(false));
//            Console.WriteLine("Поколение объекта: {0}", GC.GetGeneration(hlp));
//            Console.Read();
//        }
//    }


//    class GarbageHelper
//    {
//        public void MakeGarbage()
//        {
//            for (int i = 0; i < 1000; i++)
//            {
//                var p = new Person();
//            }
//        }

//        class Person
//        {
//            private string _name;
//            private string _surname;
//            private byte _age;

//            public Person(string name, string surname, byte age)
//            {
//                this._age = age;
//                this._name = name;
//                this._surname = surname;
//            }

//            public Person()
//                : this("", "", 0)
//            {
//            }
//        }
//    }
//}


//2. Финализатор и метод Finalizе класса System.Object.
//System.IO.FileStream, System.Net.Socket, System.Threading.Mutex 

//using System;

//namespace FinalizeExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass mc = new MyClass();

//        }
//    }
//    class MyClass
//    {
//        public MyClass()
//        {
//            Console.WriteLine("Создание объекта");
//        }


//        ~MyClass()
//        {
//            Console.WriteLine("Уничтожение объекта");
//        }
//    }

//}



