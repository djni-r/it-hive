using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPN
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression;

            // read expression from console
            expression = Console.ReadLine();

            // change the expression
            expression = toPostfixNot(expression);
            
            // print out the expression
            Console.WriteLine(expression);
            Console.ReadKey();
        }

        /// <summary>
        ///  converts expression from infix to postfix notation
        ///  e.g. a + b = a b + ; (a + b) * c = a b + c * ;
        ///  (a + b * (c - d) / e ^ f) * g + h
        ///  a b c d - * e f ^ / + g * h +
        ///  NOTE: if there are open parenthesis in return postfix expression, 
        ///  there were too many in infix one;
        ///  if there are too many close-parenth in infix, they will be disregarded
        /// </summary>
        /// <param name="expression">infix string to be converted</param>
        /// <returns>converted postfix string</returns>
        public static string toPostfixNot(string expression)
        {
            // create new string and stack to hold exit expressions
            string exit = "";
            Stack<char> stack = new Stack<char>();
            
            foreach (var ch in expression)
            {
                if (char.IsLetter(ch) || char.IsDigit(ch)) // if operand move to exit
                    exit += ch;
                else if (ch == '(') // if 'open parenth' move it to stack
                    stack.Push(ch);
                else if (ch == ')') // if 'close parenth' move everything from stack
                {                   // to exit until ecounter 'open parenth'
                    while (stack.Count() != 0 && stack.Peek() != '(')
                        exit += stack.Pop();
                    if (stack.Count() != 0) stack.Pop(); // throw 'open parenth' away
                }
                else if (ch.isOperat()) // if is an operator
                {
                    // check whether put to exit or to stack
                    OperatorClass stackOp = new OperatorClass(); // new class instance -->
                    try { stackOp = new OperatorClass(stack.Peek()); } // to compare top of stack with ch -->
                    catch (InvalidOperationException IOE) {/*do nothing*/}
                    if (stackOp >= ch) // overloaded for priority here <--
                    {    
                        exit += stack.Pop();
                        stack.Push(ch);
                    }
                        else
                        stack.Push(ch);
                }
            }

            // move the rest from the stack to exit expression
            while (stack.Count > 0)
            {
                exit += stack.Pop();
            }
            return exit;
        }    
    }
}
