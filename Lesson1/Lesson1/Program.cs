using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        private static void PrintHelloWorld()
        {
            Console.WriteLine("HelloWorld");
        }
        static void Main(string[] args)
        {
            PrintHelloWorld();
            int x = new int();

            Console.WriteLine("x = " + x);

            int n = 6;
            int [] array = new int[n];

            for (int i=0;i<n;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(var num in array)
            {
                Console.WriteLine(num);
            }

            //ждём нажатия, чтобы не закрывать консоль
            Console.ReadKey();
        }
    }
}
