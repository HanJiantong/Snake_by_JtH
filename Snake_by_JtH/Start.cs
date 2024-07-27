using System;

namespace Snake_by_JtH
{
    class Start
    {
        public static void MainStart()
        {
            // 清屏并显示游戏开始界面               
            Console.Clear();
            Console.WriteLine("Snake");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
            // 绘制游戏开始界面的ASCII艺术
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                        _______                                |                                    |");
            Console.WriteLine("|                       /                                       |                                    |");
            Console.WriteLine("|                      /                                        |                                    |");
            Console.WriteLine("|                      \\                                        |                                    |");
            Console.WriteLine("|                       \\_______      +------\\       ------+    |     /       ____                   |");
            Console.WriteLine("|                               \\     |       \\     /      |    |____/       /    \\                  |");
            Console.WriteLine("|                                \\    |       |    /       |    |    \\      /______\\                 |");
            Console.WriteLine("|                                /    |       |    \\       |    |     \\     \\                        |");
            Console.WriteLine("|                        _______/     |       |     \\______|    |      \\     \\____/                  |");
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
            Console.WriteLine($"|    v{Program.Version}                                                                                          |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("按任意键进入游戏");
            Console.ReadKey();

            if (Program.FirstStart)
            {
                Settings.CharSettings();
            }

            return;
        }
    }
}