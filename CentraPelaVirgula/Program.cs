using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shows dot instead of comma
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Give 4 real numbers: ");
            //1st input
            string input_num1 = Console.ReadLine();
            float input1 = float.Parse(input_num1);
            //2nd input
            string input_num2 = Console.ReadLine();
            float input2 = float.Parse(input_num2);
            //3rd input
            string input_num3 = Console.ReadLine();
            float input3 = float.Parse(input_num3);
            //4th input
            string input_num4 = Console.ReadLine();
            float input4 = float.Parse(input_num4);

            //Write inputs on screen
            Console.WriteLine($"{input1,6:f2}");
            Console.WriteLine($"{input2,6:f2}");
            Console.WriteLine($"{input3,6:f2}");
            Console.WriteLine($"{input4,6:f2}");

        }
    }
}
