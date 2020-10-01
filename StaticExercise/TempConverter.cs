using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double F = 0;
        public static double C = 0;
        public static double FahrenheitToCelsius(double fTemp)
        {
            C = (fTemp - 32) / 1.8;
            return C;
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            F = (cTemp * 9) / 5 + 32;
            return F;
        }
    }
}
