using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [7] {1,3,29,65,5,11,0};
            float S = 0;
            float count = S/7;   
            for (int i = 0; i < 7; i++)
            { 
              S+= array[i];
             count= S/7;    
                Console.Write ("{0}", array [i]);
             }
            Console.WriteLine();
            Console.WriteLine(S);
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
