using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; 
            int min; 
            int max; 
            for (int i = 0; i != 10; i++) 
            {
                Console.WriteLine("Enter a number", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            } 
            max = array[0];
            min = array[0];
            for (int i = 1; i != 10; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Мaximum: {0}", max);
            Console.WriteLine("Minimum: {0}", min);
        }
    }
}
