using System;

namespace Snake
{
    class Program
    {
        public static Int16 t = 10000;

        static void Main(string[] args)
        {
            Console.Title = "Snake";
            Console.CursorVisible = false;

            while (true)
            {
                Int32 n = Snake.Menu.MainMenu();

                if (n == 0)
                {
                    break;
                }
                else if (n == 1)
                {
                    Int32 score = Snake.Game.MainGame();
                    Snake.Fail.MainFail(score);
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