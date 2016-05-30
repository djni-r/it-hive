using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPN
{
    class OperatorClass
    {
        char ch;

        // constructors
        public OperatorClass() {}
        public OperatorClass(char ch) { this.ch = ch; }

        /// <summary>
        /// Operator overload of greater or equal precedence 
        /// (and less or equals) for OperatorClass and operatic char
        /// </summary>
        /// <param name="ch1">OperatorClass type</param>
        /// <param name="ch2">char</param>
        /// <returns>true if a char field of Operator class has greater or equal precedence with char,
        /// in all other cases (e.g. char is not operatic) returns false</returns>
        public static bool operator >=(OperatorClass ch1, char ch2)
        {
            if (ch1.ch == '\0') return false;
            else if (ch2 == '\0') return true;
            else if ( ((ch1.ch == '^') && (ch2 == '*' || ch2 == '/' || ch2 == '+' || ch2 == '-' )) // greater
                   || ((ch1.ch == '*' || ch1.ch == '/') && (ch2 == '+' || ch2 == '-')) // greater
                   || ((ch1.ch == '*' || ch1.ch == '/') && (ch2 == '*' || ch2 == '/')) // equals
                   || ((ch1.ch == '+' || ch1.ch == '-') && (ch2 == '+' || ch2 == '-')) // equals
                    )
                return true;
            else
                return false;
        }
        
        public static bool operator <=(OperatorClass ch1, char ch2)
        {
            if (ch1.ch == '\0') return true;
            else if (ch2 == '\0') return false;
            else if (!(ch1 >= ch2) // not greater or equals
                   || (((ch1.ch == '*' || ch1.ch == '/') && (ch2 == '*' || ch2 == '/')) // or equals
                   || ((ch1.ch == '+' || ch1.ch == '-') && (ch2 == '+' || ch2 == '-'))) // or equals
                    )
                return true;
            else return false;
        }
    }
}
