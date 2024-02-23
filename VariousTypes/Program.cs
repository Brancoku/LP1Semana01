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

            //Imprimir no ecrã o valor dos diferentes caracteres
            Console.WriteLine($"{women} \\u271d");
            Console.WriteLine($"{love} \\u2640");
            Console.WriteLine($"{church} \\u2764");

            //Criar variáveis reais de diferentes tipos inicializadas com literais adequados
            
        }
    }
}
