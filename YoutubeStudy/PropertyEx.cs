using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    class PropertyEx
    {
        int num1 = 100;

        internal int X 
        {
            get { return num1;}
            set { num1 = value; }
        }
    }
}
