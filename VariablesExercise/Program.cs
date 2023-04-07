namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string name = "Tori";
            int age = 31;
            char lastInitial = 'W';
            bool isTall = true;
            double temperature = 93.6;
            decimal futureTemperature = 76.75m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"lastInitial: {lastInitial}");
            Console.WriteLine($"isTall: {isTall}");
            Console.WriteLine($"temperature: {temperature}");
            Console.WriteLine($"futureTemperature: {futureTemperature}");
            Console.WriteLine($"My name is {name}, My age is {age}, My last name begins with {lastInitial}, \n" +
               $"Some people say I am {isTall}, The temperature right now is {temperature}, it will be {futureTemperature} later");


        }
    }
}
