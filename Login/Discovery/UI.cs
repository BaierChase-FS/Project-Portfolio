using System;

//Chase Baier
//ADF
//10/30/2020
//Synopsis: UI class hold header,seperator,footer and other utility methods for app design and appeal

namespace Discovery
{
    public static class UI
    {
        //Header method displays text in all upper case with upper and lower borders 
        public static void Header(string text)
        {
            //Set console color for header display
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("================================================\r\n");
            Console.WriteLine($"{text.ToUpper()}");
            Console.WriteLine("\r\n================================================");
        }
        //Seperator method displays a line to seperate sections of the app 
        public static void Seperator()
        {
            //Set color for seperator
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"\r\n------------------------------------------------\r\n");
        }
        //Footer method displays the footer with a border above it to 
        public static void Footer(string text)
        {
            //Set Footer display color
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("================================================\r\n");
            Console.WriteLine($"{text.ToUpper()}");
        }
       
    }
}
