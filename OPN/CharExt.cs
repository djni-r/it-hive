using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPN
{
    public static class CharExt
    {
        // check whether a char is an operator
        public static bool isOperat(this char ch)
        {
            if (ch == '+'
                || ch == '-'
                || ch == '*'
                || ch == '/'
                || ch == '^')
                return true;
            else return false;
        }
    }
}
