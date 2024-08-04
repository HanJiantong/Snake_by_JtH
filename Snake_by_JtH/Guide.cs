using System;
using System.Threading;

namespace Snake_by_JtH
{
    class Guide
    {
        public static void MainGuide()
        {
            Int32 i = 0;
            String Head = Program.Unicode ? "██" : "><", Body = Program.Unicode ? "░░" : "[]", Food = Program.Unicode ? "■ " : "~ ";

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey(true);

                    if (Key.Key == ConsoleKey.Escape) return;
                    if (Key.Key == ConsoleKey.Enter) break;
                }

                Thread.Sleep(0);

                if (i == 1E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W、S、A、D、键以控制蛇头方向，请注意使用英文输入法，不区分大小写                               |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下：W                                                                                        |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                             {Head}                              |                     |");
                    Console.WriteLine($"|                |                             {Body}                              |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页1共4");
                }

                if (i == 2E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W、S、A、D、键以控制蛇头方向，请注意使用英文输入法，不区分大小写                               |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下：D                                                                                        |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                             {Body}{Head}                            |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页1共4");
                }

                if (i == 3E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W、S、A、D、键以控制蛇头方向，请注意使用英文输入法，不区分大小写                               |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下：S                                                                                        |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                               {Body}                            |                     |");
                    Console.WriteLine($"|                |                               {Head}                            |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页1共4");
                }

                if (i == 4E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W、S、A、D、键以控制蛇头方向，请注意使用英文输入法，不区分大小写                               |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下：A                                                                                        |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                             {Head}{Body}                            |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页1共4");
                    i = 0;
                }

                i++;
            }

            i = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey(true);

                    if (Key.Key == ConsoleKey.Escape) return;
                    if (Key.Key == ConsoleKey.Enter) break;
                }

                Thread.Sleep(0);

                if (i == 1E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 控制蛇头以吃到食物以得分                                                                           |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                            {Food}    {Head}{Body}                       |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数：00000                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页2共4");
                }

                if (i == 2E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 控制蛇头以吃到食物以得分                                                                           |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                            {Food}  {Head}{Body}                         |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数：00000                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页2共4");
                }

                if (i == 3E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 控制蛇头以吃到食物以得分                                                                           |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                            {Food}{Head}{Body}                           |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数：00000                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页2共4");
                }

                if (i == 4E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 控制蛇头以吃到食物以得分                                                                           |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                            {Head}{Body}                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数：00001                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页2共4");
                }

                if (i == 5E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 控制蛇头以吃到食物以得分                                                                           |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                          {Head}{Body}                               |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数：00001                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页2共4");
                }

                if (i == 6E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 控制蛇头以吃到食物以得分                                                                           |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                        {Head}{Body}                                 |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数：00001                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页，Esc键以退出                                                            页2共4");
                    i = 0;
                }

                i++;
            }
        }
    }
}
