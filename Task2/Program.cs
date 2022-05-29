using System;
using System.Collections.Generic;
using System.Threading;

namespace Task2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите желаемый объем потребления рессурсов в байтах");
            string input = Console.ReadLine();
            GCWrapper wrapper = new GCWrapper(long.Parse(input));
            List<TestObject> list = new List<TestObject>();
            while (true)
            {
                list.Add(new TestObject());
                Console.WriteLine($"Добавлен объект, объем памяти {GC.GetTotalMemory(false)}");
                wrapper.CheckMemoryLevel();
                Thread.Sleep(1000);
            }
        }
    }
}
