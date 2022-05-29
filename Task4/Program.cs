using System;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                TestObject test = new TestObject();
                Console.WriteLine($"Память: {GC.GetTotalMemory(false)}");
                if (count > 50)
                {
                    test.Dispose();
                }
                count++;
                Thread.Sleep(100);
            }
        }
    }
}
