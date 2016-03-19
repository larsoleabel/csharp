using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i * i;

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);

            string s = "Test";
            string t = string.Copy(s);
            Console.WriteLine(s == t);
            Console.WriteLine((object)s == (object)t);
            Console.WriteLine(3.ToString());
            Console.WriteLine("4");

            Console.ReadLine();
        }
    }
}
