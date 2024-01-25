using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin_packing_25._1._24
{
    internal class Program
    {
        struct bin
        {
            public int capacity;
            public string packages;

        }
        static void Main(string[] args)
        {
            Console.Write("Input Bin size:  ");
            int binsz = int.Parse(Console.ReadLine());
            Console.Write("Input packet sizes(x,x,x,x,x,x..): ");
            string packsz = Console.ReadLine();
            string[] packsizes;
            packsizes = packsz.Split(',');

            for(int i = 0; i < packsizes.Length; i++)
            {
                
            }

            List<bin> bins = new List<bin>();

            bin b;
            b.capacity = binsz;
            b.packages = "";
            bins.Add(b);
            bin thisbin = bins[0];
            thisbin.packages += packsizes[0] + ",";
            thisbin.capacity -= int.Parse(packsizes[0]);

            bins[0] = thisbin;

            


        }
    }
}
