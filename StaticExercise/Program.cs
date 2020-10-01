using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(32));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(0));

            Console.WriteLine(TempConverter.FahrenheitToCelsius(212));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(100));
        }
    }
}
