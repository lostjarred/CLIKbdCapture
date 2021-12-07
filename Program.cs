using System;

namespace KBDCommandLineCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //xy for welcome msg
            int[] kbdwelcomxy = new int[2] { 0, 1 };
            //xy for key output
            int[] kbdkeeyxy = new int[2] {0, 3};
            //xy for whether the key was captured
            int[] kbdstatusxy = new int[2] {0, 5};
            System.ConsoleKey keypress;

            //initial screen draw before loop
            Console.SetCursorPosition(kbdwelcomxy[0], kbdwelcomxy[1]);
            Console.Write("Welcome to my Keyboard Capture Program");
            Console.SetCursorPosition(kbdkeeyxy[0], kbdkeeyxy[1]);
            Console.Write(" ");
            Console.SetCursorPosition(kbdstatusxy[0], kbdstatusxy[1]);
            Console.Write("> NO KEY");
            
            //main loop
            while (true)
            {
                keypress = 0;
                //read keypress
                keypress = Console.ReadKey(false).Key;
                //redraw screen method
                redrewscreen();
            }

            void redrewscreen()
            {
                //clear the screen
                clearLine(kbdkeeyxy[1]);
                clearLine(kbdstatusxy[1]);
                Console.SetCursorPosition(kbdwelcomxy[0], kbdwelcomxy[1]);
                Console.Write("Welcome to my Keyboard Capture Program");
                Console.SetCursorPosition(kbdkeeyxy[0], kbdkeeyxy[1]);
                //logic for if a key was captured
                if (keypress == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(keypress + "(" + ((int)keypress) +")");
                }
                Console.SetCursorPosition(kbdstatusxy[0], kbdstatusxy[1]);
                //logic for status bar at bottom
                if (keypress == 0)
                {
                    Console.Write("> NO KEY");
                }
                else
                {
                    Console.Write("> KEY CAPTURED");
                }
            }

            void clearLine(int y)
            {
                //small method to clear the line
                Console.SetCursorPosition(0, y);
                for (int i = 0; i < 200; i ++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
