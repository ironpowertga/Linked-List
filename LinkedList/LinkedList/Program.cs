using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            
            list.Push(10);
            list.Push(11);
            list.Push(12);

            Console.WriteLine(list[2]);

            Console.WriteLine(list.Length);

            Console.ReadKey();
        }
    }
}
