using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci(10);
            foreach (var item in fibonacci)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    class Fibonacci
    {
        private int _lastNumber;
        public Fibonacci(int lastNumber)
        {
            _lastNumber = lastNumber;
        }
        public IEnumerator GetEnumerator()
        {
            yield return 0; yield return 1;
            int a = 0, b = 1;
            while (true)
            {
                int next = a + b;
                if (next > _lastNumber)
                    break;
                yield return next;
                a = b;
                b = next;
            }
        }
    }
}
