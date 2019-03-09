using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informator
{
    class LastInfoPanelPosition
    {
        private static System.Drawing.Point lastInfoPanelPosition;

        public static void set(System.Drawing.Point p)
        {
            lastInfoPanelPosition = p;
        }

        public static System.Drawing.Point get()
        {
            return lastInfoPanelPosition;
        }
    }
}
