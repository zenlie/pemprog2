using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1184109
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU EMPAT PERSEGI PANJANG");
            Console.WriteLine("1) Hitung luas");
            Console.WriteLine("2) Hitung keliling");
            Console.WriteLine("3) Hitung panjang diagonal");
            Console.WriteLine("4) Keluar program");
            Console.Write("\r\nMenu pilihan     : ");

            switch (Console.ReadLine())
            {
                case "1":
                    Luas();
                    return true;
                case "2":
                    Keliling();
                    return true;
                case "3":
                    PanjangDiagonal();
                    return true;
                case "4":
                    Exit();
                    return false;
                default:
                    return true;
            }
        }

        private static void Luas()
        {
            double panjang;
            double lebar;
            double luas;
      
            Console.Write(" panjang : ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write(" lebar : ");
            lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write(" hasil : ");
            luas = panjang * lebar;
            Console.Write(luas);
            Console.ReadLine();
            System.Environment.Exit(-1);
        }

        private static void Keliling()
        {
            double panjang;
            double lebar;
            double keliling;

            Console.Write(" panjang : ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write(" lebar : ");
            lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write(" hasil : ");
            keliling = (2*panjang) + (2*lebar);
            Console.Write(keliling);
            Console.ReadLine();
            System.Environment.Exit(-1);
        }

        private static void PanjangDiagonal()
        {
            double panjang;
            double lebar;
            double diagonal;

            Console.Write(" panjang : ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write(" lebar : ");
            lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write(" hasil : ");
            diagonal = (panjang * panjang) + (lebar * lebar);
            Console.Write(diagonal);
            Console.ReadLine();
            System.Environment.Exit(-1);
        }

        private static void Exit()
        {

            System.Environment.Exit(-1);
        }
    }
}
