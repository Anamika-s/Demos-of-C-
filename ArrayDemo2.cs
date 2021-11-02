using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class ArrayDemo2
    {
        static void Main()
        {
            int[] num = new int[10];
            Console.WriteLine("Enter Elements");
            int sum = 0;
            for(int i=0;i<10;i++)
            {
                num[i] = Convert.ToByte(Console.ReadLine());
                sum += num[i];
            }
            float avg = (float)sum / 10;
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + avg);
            

        }
    }
}
