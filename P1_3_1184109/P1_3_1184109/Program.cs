using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1184109
{
    class Program
    {
        static void Main(string[] args)
        {
            string ayam;
            int n;
            Console.WriteLine("nilai N harus positif dan tidak boleh 0 dan maksimal adalah 10. contoh 1,2,3,..10");
            Console.WriteLine("the value of N must be positive and cannot be 0 and maximal is 10.example 1,2,3,..10");
            Console.WriteLine("N : ");
            ayam = Console.ReadLine();
            n = Convert.ToInt16(ayam);

            if (n >= 1 && 10 >= n)
            {
                for (int i = n; i > 1; i--)
                {
                    Console.WriteLine("Anak ayam turun {0} Mati satu tinggal {1}", i, i - 1);
                }
                Console.WriteLine("Anak ayam turun 1 Mati satu tinggal induknya");
                Console.ReadLine();
            }else
            Console.WriteLine("Maaf minimal untuk input ayam adalah 1 dan maksimal adalah 10");
        }
    }
}
