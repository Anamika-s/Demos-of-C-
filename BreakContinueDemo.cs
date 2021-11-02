using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class BreakContinueDemo
    {
        static void Main()
        {
            int[] num = new int[10];
            Console.WriteLine("Enter Numbers");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToSByte(Console.ReadLine());
                if (num[i] < 0) continue;
                // continue is used to skip remaining statements of the loop 
                // it moves to the next iteration of the loop
                if (num[i] == 0) break; 
                // break : is used to come out of the loop
                sum += num[i];
            }
            float avg = (float)sum / 10;
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + avg);
        }
    }
}
