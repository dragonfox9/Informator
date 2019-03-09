using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informator
{
    class GlobalInfoPanelndex
    {
        private static long index = 0;

        public static long currentIndex
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
    }
}
