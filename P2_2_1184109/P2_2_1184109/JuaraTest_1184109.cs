using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184109
{
    class JuaraTest_1184109
    {
        static void Main(String[] args)
        {
            Lompat_1184109 category1 = new Lompat_1184109("Lompat Pagar", "John", "90");
            Lari_1184109 category2 = new Lari_1184109("John", "145");

            Console.WriteLine("Juara lomba {0} adalah {1} dengan nilai {2} poin",
                category1.Mytype, category1.Mytitle, category1.PageCount);

            Console.WriteLine("Juara lomba {0} adalah {1} dengan durasi {2} detik",
                category2.Mytype, category2.Mytitle, category2.Duration);
        }
    }
}
