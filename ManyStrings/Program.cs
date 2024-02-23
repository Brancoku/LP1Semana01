using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            double xx = 1.23456;
            int ii = 19;

            //ex 4 
            string abc = "abc";
            string def = "d" + "e" + "f";
            string ghi = "ghi " + x;
            ghi += " end txt";

            Console.WriteLine(abc);
            Console.WriteLine(def);
            Console.WriteLine(ghi);
            Console.WriteLine($"{x} + {y} = {x + y}");

            //ex 5
            string jkl = $"x = {xx:f1}";
            string mno = $".{10,4:x}. e .{11,-4:x}.";
            string pqr = $"{5,-6:f2} e {0.2:p1}";

            Console.WriteLine(jkl);
            Console.WriteLine(mno);
            Console.WriteLine(pqr);

            //ex 6

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");

            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}
