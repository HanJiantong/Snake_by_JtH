using System;

namespace Snake_by_JtH
{
    class Fail
    {
        public static void MainFail(Int32 Score)
        {
            // 清屏并显示游戏结束界面
            Console.Clear();
            Console.WriteLine("Snake");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            // 绘制游戏结束界面的ASCII艺术
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                         ___                      ___                                               |");
            Console.WriteLine("|                        /                        /   \\                                              |");
            Console.WriteLine("|                        |___              __     |   |                                              |");
            Console.WriteLine("|                        |  /|  --| |-\\/- /  \\    |   | |   | /  \\ | _/                              |");
            Console.WriteLine("|                        \\  || /  | | | | |--/    |   | \\  /  |--/  |                                |");
            Console.WriteLine("|                         ---| \\__| | | | \\__     \\___/  \\/   \\__   |                                |");
            Console.WriteLine("|                                   得分:{0}                                                       |", Score.ToString("D5"));
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.Write("请按任意键继续. . .");
            Console.Beep();
            Console.Beep();
            Console.ReadKey();
            return;
        }
    }
}
