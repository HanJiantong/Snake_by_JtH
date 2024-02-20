using System;

namespace Snake_by_JtH
{
    class Program
    {
        public static Int16 Speed = 10000;
        public static Boolean Unicode = true;

        static void Main(String[] args)
        {
            Console.Title = "Snake";
            Console.CursorVisible = false;

            while (true)
            {
                Int32 n = Menu.MainMenu();

                if (n == 0)
                {
                    break;
                }
                else if (n == 1)
                {
                    Int32 score = Game.MainGame();
                    Fail.MainFail(score);
                }
                else if (n == 2)
                {
                    Settings.MainSettings();
                }
            }

            return;
        }
    }
}