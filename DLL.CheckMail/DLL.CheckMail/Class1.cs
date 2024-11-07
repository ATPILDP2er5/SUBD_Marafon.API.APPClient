using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLCheckMail
{
    public static class Cy
    {
        public static bool CheckMail(string Mail)
        {
            for (int i = 0; i < Mail.Length-1; i++)
            {
                if (Mail[i] == '@')
                    for (int j = 2; j < Mail.Length - 1; j++)
                    {
                        if (Mail[j] == '.')
                            return true;
                    }
            }
            return false;
        }
    }
}
