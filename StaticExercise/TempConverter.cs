using System;
namespace StaticExercise
{
    public  static class TempConverter
    {
        public static double FarenheitToCelcius(double farenheit)
        {
            return (farenheit - 32) / 1.8;
        }

        public static double CelciusToFarenheit (double celcius)
        {
            return (celcius * 1.8) + 32;
        }

       

    }
}

