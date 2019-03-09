using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informator
{
    class UserInfo
    {
        public static string userName;
        private static bool isAdmin = false;

        public static void setAdminPermissions(bool adminPermissions)
        {
            isAdmin = adminPermissions;
        }

        public static bool getAdminPermissions()
        {
            return isAdmin;
        }
    }
}
