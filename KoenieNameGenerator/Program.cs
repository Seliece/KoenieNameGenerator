using System;

namespace KoenieNameGenerator
{
    class Program
    {

        static void Main(string[] args)
        {

            // Defines String Arrays
            
            string[] BeginPart = new string[]
            {
                "Koenie",
                "#BoyFriend",
                "Koen",
                "DaddyKoen",
            };
            string[] EndPart = new string[]
            {
                "06",
                "Sexy",
                "Koen",
                "Cummy",
            };

            //Start Code

            while (true)
            {
                Console.ReadKey();
                ClearCurrentConsoleLine();
                Console.WriteLine("Koenies new name is: " + RandomPart(BeginPart) + RandomPart(EndPart));
            }
        }

        // Selectes Random Part

        public static string RandomPart(string[] part)
        {
            Random rand = new Random();
            int index = rand.Next(part.Length);
            string Answer = part[index];
            return Answer;
        }

        // Clears Last Typed Line
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
