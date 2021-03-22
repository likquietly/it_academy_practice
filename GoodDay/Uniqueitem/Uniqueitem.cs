using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniqueitem
{
    class Uniqueitem
    {
        public static int id = 0;

        public Uniqueitem()
        {
            id++;
        }

        public Uniqueitem(int newId)
        {
            id = newId;
            id++;
        }
    }
}