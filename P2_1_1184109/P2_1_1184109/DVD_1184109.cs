using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184109
{
    public class DVD_1184109 : Product_1184109
    {
        protected string duration;
        public DVD_1184109(string title, string duration)
        {
            this.Mytitle = title;
            this.Duration = duration;
            this.Mytype = "DVD";

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
    }
}
