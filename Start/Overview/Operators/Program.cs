﻿using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            string a="abcd", b="efgh";

            // TODO: Basic math operators are +, -, /, *
            // Console.WriteLine("----- Basic Math -----");
            // Console.WriteLine((x / y) * x);
            // Console.WriteLine(a + b);

            // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            x++;
            y--;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // TODO: Operators can be shorthand: a = a + b
            // a += b;
            // Console.WriteLine(a);

            // TODO: Logical operators &&, ||
            // Console.WriteLine("----- Logic Operators -----");
            // Console.WriteLine(x > y && y >= 5 );
            // Console.WriteLine(x > y || y >= 5 );

            // null-coalescing operators
            string str = "hello";
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            Console.WriteLine(str ?? "Unknown string");

            

            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            str ??= "New String";
            Console.WriteLine(str);
        }
    }
}
