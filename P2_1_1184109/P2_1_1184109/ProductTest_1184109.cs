using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184109
{
    class ProductTest_1184109
    {
        static void Main(String[] args)
        {
            Book_1184109 product1 = new Book_1184109("Book", "C# Object Oriented Solution", "300");
            DVD_1184109 product2 = new DVD_1184109("Ethernal", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages",
                product1.Mytype, product1.Mytitle, product1.PageCount);

            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} mminute duration",
                product2.Mytype, product2.Mytitle, product2.Duration);
        }
    }
}
