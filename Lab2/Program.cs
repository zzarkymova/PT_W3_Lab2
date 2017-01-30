using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Program
    {
        static void Main(string[] args)
        {
           
            int min = int.MaxValue; 
            int max = int.MinValue;

            FileStream fs = new FileStream(@"C:\temp2\numbers.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);


            while (!sr.EndOfStream)
            {
               string text = sr.ReadLine();
               string[] split = text.Split(new Char[] { ' ', ',', '.', ':', '\t' });
               int k = int.Parse(text);
               min = Math.Min(min, k);
               max = Math.Max(max, k);
            }



      /*      while (!sr.EndOfStream) 
            {
                string text = sr.ReadLine();
                int k = int.Parse(text);
                min = Math.Min(min, k);
                max = Math.Max(max, k);
            } */

            sr.Close();
            fs.Close();

        
            Console.WriteLine("Мaximum: {0}", max);
            Console.WriteLine("Minimum: {0}", min);
        }
    }
}
