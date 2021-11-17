using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184109
{
    class Lompat_1184109 : Juara_1184109
    {
        protected string pageCount;

        public Lompat_1184109(string type, string title, string pagecount)
            : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
