using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_ChekPass
{
    public static class ChekcPass
    {
        public static CheckList Check(string g)
        {
            char[] chars = { '!','@', '#', '$', '%', '^'};
            CheckList checkList = new CheckList();
            if (g.Length < 6)
                checkList.a = false;
            if (!g.Any(char.IsUpper))
                checkList.b = false;
            if (!g.Any(char.IsDigit))
                checkList.c = false;
            if (!g.Any(chars.Contains))
                checkList.d = false;
            return checkList;
        }
    }
}
