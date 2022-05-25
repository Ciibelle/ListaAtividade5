using System;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            double fh = 96.8;
            double gc = 0;

            gc = (fh - 32)*5/9;
            Console.WriteLine($"A conversão de Fahrenheit para grau Celsius: {gc}");
        }
    }
}
