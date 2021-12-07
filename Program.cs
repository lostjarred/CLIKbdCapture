using System;

namespace KBDCommandLineCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int[] kbdwelcomxy = new int[2] { 0, 1 };
            int[] kbdkeeyxy = new int[2] {0, 3};
            int[] kbdstatusxy = new int[2] {0, 5};
            System.ConsoleKey keypress;

            Console.SetCursorPosition(kbdwelcomxy[0], kbdwelcomxy[1]);
            Console.Write("Welcome to my Keyboard Capture Program");
            Console.SetCursorPosition(kbdkeeyxy[0], kbdkeeyxy[1]);
            Console.Write(" ");
            Console.SetCursorPosition(kbdstatusxy[0], kbdstatusxy[1]);
            Console.Write("> NO KEY");
            
            while (true)
            {
                keypress = 0;
                keypress = Console.ReadKey(false).Key;
                redrewscreen();
            }

            void redrewscreen()
            {
                Console.Clear();
                Console.SetCursorPosition(kbdwelcomxy[0], kbdwelcomxy[1]);
                Console.Write("Welcome to my Keyboard Capture Program");
                Console.SetCursorPosition(kbdkeeyxy[0], kbdkeeyxy[1]);
                if (keypress == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(keypress + "(" + ((int)keypress) +")");
                }
                Console.SetCursorPosition(kbdstatusxy[0], kbdstatusxy[1]);
                if (keypress == 0)
                {
                    Console.Write("> NO KEY");
                }
                else
                {
                    Console.Write("> KEY CAPTURED");
                }
            }
        }
    }
}
