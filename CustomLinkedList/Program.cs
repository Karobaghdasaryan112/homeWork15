using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<string> strings = new CustomLinkedList<string>();
            strings.Add("a");
            strings.Add("b");
            strings.Add("c");
            strings.Add("d");
            strings.Add("e");
            strings.Add("f");
            strings.Remove("f");
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
