using System;

namespace Task2
{
    partial class Program
    {
        internal class GCWrapper
        {
            public GCWrapper(long memoryLevel)
            {
                MemoryLevel = memoryLevel;
            }

            public long MemoryLevel { get; set; }

            public void CheckMemoryLevel()
            {
                if (GC.GetTotalMemory(false) > MemoryLevel)
                {
                    Console.WriteLine(
                        $"Объем занимаемой памяти больше установленного, установлено: {MemoryLevel} , фактический объем: {GC.GetTotalMemory(false)}");
                    GC.Collect();
                }
            }
        }
    }
}
