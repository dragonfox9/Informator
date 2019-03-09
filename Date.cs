using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informator
{
    class Date
    {
        private static DateTime date = DateTime.Now;

        public static void setDate(DateTime dt)
        {
            date = dt;
        }

        public static DateTime getDate()
        {
            return date;
        }

        public static bool isExpired(DateTime dt)
        {
            return dt < DateTime.Now;
        }
    }
}
