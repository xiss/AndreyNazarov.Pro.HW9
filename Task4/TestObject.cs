using System;

namespace Task4
{
    internal class TestObject : IDisposable
    {
        private int[] arr;
        private bool disposed;

        public TestObject()
        {
            // 4* 1024* 1
            arr = new int[1024 * 1024];
        }


        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool IsDispousing)
        {
            if (disposed)
            {
                return;
            }

            if (IsDispousing)
            {
                arr = null;
                Console.WriteLine("Освобождаем управляемые ресурсы");
                GC.SuppressFinalize(this);
                disposed = true;
            }
            Console.WriteLine("Освобождаем неуправляемые ресурсы");
        }

        ~TestObject()
        {
            Dispose(false);
        }
    }
}
