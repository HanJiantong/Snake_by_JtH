using System;

namespace Snake
{
    class Fail
    {
        public static void MainFail(Int32 score)
        {
            Console.Clear();
            Console.WriteLine("Snake");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
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
            Console.WriteLine("|                                   得分:{0}                                                       |", score.ToString("D5"));
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
