using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilken stad kommer du ifrån? ");
            string stad = Console.ReadLine(); 
            Console.Write("Vilket är ditt drömresemål? ");
            string resemål = Console.ReadLine();    
            Console.Write("Hej " + (stad) + "-bo. Hoppas du får resa till " + (resemål));

        }
    }
}
