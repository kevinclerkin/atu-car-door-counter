public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Car Door Counter!");
    }

    public class Car
    {
        private readonly int _numberOfDoors = 2;

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
        }
    }
}