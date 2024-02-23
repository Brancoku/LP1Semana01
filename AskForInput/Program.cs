using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a int number:");
            string input = Console.ReadLine();
            int.TryParse(input, out int intValue);

            Console.WriteLine("Give me a real number:");
            string input2 = Console.ReadLine();
            float.TryParse(input2, out float floatValue);
            
            float soma = intValue + floatValue;
            Console.WriteLine($"{input} + {input2} = {soma}");
        }
    }
}
