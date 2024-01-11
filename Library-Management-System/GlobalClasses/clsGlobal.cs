using Library_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.GlobalClasses
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser = clsUser.Find(1);
    }
}
