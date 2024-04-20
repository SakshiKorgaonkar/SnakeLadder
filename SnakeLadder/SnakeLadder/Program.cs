// See https://aka.ms/new-console-template for more information
namespace SnakeLadder
{
    internal class Program
    {
        int initial;

        Program()
        {
            this.initial = 0;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Program program = new Program();
            program.initial = random.Next(1,6);
            Console.WriteLine("Number generated : "+ program.initial);
        }
    }
}
