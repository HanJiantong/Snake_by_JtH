using System;

namespace Snake_by_JtH
{
    class Menu
    {
        public static Int32 MainMenu()
        {
            // 清屏并显示主菜单
            Console.Clear();
            Console.Write("Snake\n" + "------------------------------------------------------------------------------------------------------\n" + "| 1.游戏                                                                                             |\n" + "| 2.设置                                                                                             |\n" + "|                                                                                                    |\n" + "| 0.退出                                                                                             |\n");

            // 绘制空白行
            for (Int32 i = 0; i < 21; i++)
            {
                Console.Write("|                                                                                                    |\n");
            }

            Console.Write("------------------------------------------------------------------------------------------------------\n" + "按下对应数字键以进入");

            // 获取用户输入并返回
            Char Key = (Char)Console.ReadKey(true).Key;
            return (Int32)Key - 48;
        }
    }
}