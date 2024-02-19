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
                Int32 n = Snake_by_JtH.Menu.MainMenu();

                if (n == 0)
                {
                    break;
                }
                else if (n == 1)
                {
                    Int32 score = Snake_by_JtH.Game.MainGame();
                    Snake_by_JtH.Fail.MainFail(score);
                }
                else if (n == 2)
                {
                    //Snake.Setting.MainSetting();
                }
            }

            return;
        }
    }
}