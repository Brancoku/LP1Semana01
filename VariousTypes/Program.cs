using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar variáveis inteiras de diferentes tipos inicializadas com literais adequados
            sbyte a = 1;
            short b = 2;
            int c = 4;
            long d = 8L;
            ulong e = 16UL;
            uint f = 32U;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            // Criar variáveis char com diferentes valores Unicode
            char church = '\u271d';
            char women = '\u2640'; 
            char love = '\u2764';

            Console.WriteLine($"{women} \\u271d");
            Console.WriteLine($"{love} \\u2640");
            Console.WriteLine($"{church} \\u2764");

            //Criar variáveis reais de diferentes tipos inicializadas com literais adequados
            float flo = 3.14f;
            double dou = 3.141;
            decimal dec = 3.1415m; 

            Console.WriteLine(flo);
            Console.WriteLine(dou);
            Console.WriteLine(dec);

            //Criar duas variáveis booleanas, uma inicializada a true, outra a false

            bool vdd = true;
            bool fls = false;

            Console.WriteLine(vdd);
            Console.WriteLine(fls);

        }
    }
}
