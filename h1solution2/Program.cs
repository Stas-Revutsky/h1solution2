namespace h1solution2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("What is your name ?");
            name = Console.ReadLine() ?? string.Empty;
            do
            {
                Console.WriteLine($"How old are you, {name}?");
            } 
            while (!int.TryParse(Console.ReadLine(), out age));
            Console.WriteLine($"Your name is {name} and your age is {age}");
        }
    }
}