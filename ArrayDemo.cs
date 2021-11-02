using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class ArrayDemo
    {
        static void Main()
        {
            Int64[] num = new Int64[10];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine("Elements are");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
