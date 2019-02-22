using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Common
{
    public class Utility
    {
        public static int CurrentDividendIndex = -1;

        public static bool Is_DWRIN_admin()
        {
            if (Environment.UserName.Equals("SHuang", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
    }
}
