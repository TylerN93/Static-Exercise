namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The Farenheit temp is {TempConverter.CelciusToFarenheit(15)}.");

            Console.WriteLine($"The Celcius temp is {TempConverter.FarenheitToCelcius(59)}.");
        }
    }
}
