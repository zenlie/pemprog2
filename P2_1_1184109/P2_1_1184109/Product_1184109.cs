using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184109
{
    public class Product_1184109
    {
        private string myType;
        private string myTitle;
        public Product_1184109()
        {

        }

        public Product_1184109(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string Mytype
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }
        public string Mytitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;
            }
        }
    }
}
