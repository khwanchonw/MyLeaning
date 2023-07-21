
namespace Console1.Lesson
{
    public class Construc
    {
        public Construc()
        {
            Console.WriteLine("nothing");
        }

        public Construc(int Value)
        {
            Console.WriteLine($"Value is {Value}");
        }

        public Construc(int Value,string Name)
        {
            Console.WriteLine($"Value is {Value}");
            Console.WriteLine($"Value is {Name}");
        }

    }
}
