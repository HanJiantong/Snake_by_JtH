using System;

namespace Snake_by_JtH
{
    class Menu
    {
        public static Int32 MainMenu()
        {
            // 清屏并显示主菜单
            Console.Clear();
            Console.WriteLine("Snake");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| 1.游戏                                                                                             |");
            Console.WriteLine("| 2.设置                                                                                             |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("| Esc.退出                                                                                           |");
            
            // 绘制空白行
            for (Int32 i = 0; i < 21; i++)
            {
                Console.Write("|                                                                                                    |\n");
            }

            Console.Write("+----------------------------------------------------------------------------------------------------+\n" + "按下对应数字键以进入");
            // 获取用户输入并返回
            Char Key = (Char)Console.ReadKey(true).Key;
            return Key;
        }
    }
}
