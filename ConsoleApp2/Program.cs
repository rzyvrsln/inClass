using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Username = Console.ReadLine(),
                Password = Console.ReadLine(),
                Product = Console.ReadLine()
            };

            Producd producd = new Producd
            {
                Name = Console.ReadLine(),
                Price = int.Parse(Console.ReadLine())
            };

            Console.WriteLine($"Username: {user.Username} Password: {user.Password}");
        }
    }
}