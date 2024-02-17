using System;

namespace Snake
{
    class Menu
    {
        public static Int32 MainMenu()
        {
            Console.Clear();
            Console.Write("Snake\n" + "------------------------------------------------------------------------------------------------------\n" + "| 1.游戏                                                                                             |\n" + "| 2.设置                                                                                             |\n" + "|                                                                                                    |\n" + "| 0.退出                                                                                             |\n");
            
            for (Int32 i = 0; i < 21; i++)
            {
                Console.Write("|                                                                                                    |\n");
            }

            Console.Write("------------------------------------------------------------------------------------------------------\n" + "按下对应数字键以进入");
            Char key = (Char)Console.ReadKey(true).Key;
            return (Int32)key - 48;
        }
    }
}
