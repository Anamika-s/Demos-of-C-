using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class MethodOverloading
    {
        static void Add(params int [] num)
        {
            int sum = 0;
            for(int i=0;i<num.Length; i++)
            {
                sum += num[i];
            }

        }
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);

        }

        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);

        }

        static void Add(int x, int y, int z, int a)
        {
            Console.WriteLine(x + y + z + a);

        }

        static void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void Add(string s1 , string s2)
        {
            Console.WriteLine(s1 + s2); ;
        }
        static void Main()
        {
            Add(1);
            Add(2, 3);
            Add(1, 2, 3);
            Add(1, 2, 3, 4, 6, 7, 7, 8, 8, 9, 9);
            Add(12.4f, 34.5f);
            Add("This", "is");
        }
    }
}
