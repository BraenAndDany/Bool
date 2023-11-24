using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using booling;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            booli booling =  new booli();

            bool first = false;
            bool second = false;
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "       |");
            Console.Write("No" + "    ");
            Console.Write("And" + "    ");
            Console.Write("Or" + "     ");
            Console.Write("Xor" + "    ");
            Console.Write("Xnor" + "   ");
            Console.Write("Impl" + "   ");
            Console.Write("NoImpl" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 4; i++) {
             if (i == 1) {
                    first = false;
                    second = true;
             }else if (i == 2)
                {
                    first = true;
                    second = false;
                }else if (i == 3)
                {
                    second = true;
                }

                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   |");
                booling.No(first, second);
                booling.And(first, second);
                booling.Or(first, second);
                booling.Xor(first, second);
                booling.Xnor(first, second);
                booling.Impl(first, second);
                booling.NoImpl(first, second);
                Console.WriteLine();
            }



        }
    }
}
