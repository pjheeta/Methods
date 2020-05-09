using System;

namespace Methods
{
    class Program
    {
        

        static string testMethod()
        {
            grevious();
            Console.WriteLine("General Kenobi, you are a bold one!");
            Console.WriteLine("Kill him!");
            lightsaber();
            grevious();
            Console.WriteLine("Back away, I shall deal with this Jedi slime myself");
            obiWan();
            string name = Console.ReadLine();
            return name;
        }

        static void obiWan()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void grevious()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }


        static void lightsaber()
        {
            obiWan();
            Console.WriteLine("Whooon, whoon, woosh, pshakkk!!");
        }

        static void Main(string[] args)
        {

            obiWan();
            Console.WriteLine("Hello There",Console.ForegroundColor);
            string nameMeethod = testMethod();
            grevious();
            Console.WriteLine("You fool!!!   I've been trained in your Jedi arts by Count Dooku");

        }

    }
}
