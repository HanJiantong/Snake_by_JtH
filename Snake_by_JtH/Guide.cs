using System;
using System.Threading;

namespace Snake_by_JtH
{
    class Guide
    {
        public static void MainGuide()
        {
            Int32 i = 0;
            String Head = Program.Unicode ? "██" : "><", Body = Program.Unicode ? "▓▓" : "[]", Food = Program.Unicode ? "■ " : "~ ";

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
                    Console.WriteLine("| 按下W, S, A, D键以控制蛇头方向, 请注意使用英文输入法, 不区分大小写                                 |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下: W                                                                                        |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页1共4");
                }
                if (i == 2E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W, S, A, D键以控制蛇头方向, 请注意使用英文输入法, 不区分大小写                                 |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下: D                                                                                        |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页1共4");
                }
                if (i == 3E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W, S, A, D键以控制蛇头方向, 请注意使用英文输入法, 不区分大小写                                 |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下: S                                                                                        |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页1共4");
                }
                if (i == 4E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 按下W, S, A, D键以控制蛇头方向, 请注意使用英文输入法, 不区分大小写                                 |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|     按下: A                                                                                        |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页1共4");
                    i = 0;
                }

                i++;
            }

            Thread.Sleep(250);
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
                    Console.WriteLine("|                分数: 00000                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页2共4");
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
                    Console.WriteLine("|                分数: 00000                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页2共4");
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
                    Console.WriteLine("|                分数: 00000                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页2共4");
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
                    Console.WriteLine("|                分数: 00001                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页2共4");
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
                    Console.WriteLine("|                分数: 00001                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页2共4");
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
                    Console.WriteLine("|                分数: 00001                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页2共4");
                    i = 0;
                }

                i++;
            }

            Thread.Sleep(250);
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
                    Console.WriteLine("| 当分数为3的倍数时, 蛇身长增加                                                                      |");
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
                    Console.WriteLine("|                分数: 00002                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页3共4");
                }
                if (i == 2E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当分数为3的倍数时, 蛇身长增加                                                                      |");
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
                    Console.WriteLine("|                分数: 00002                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页3共4");
                }
                if (i == 3E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当分数为3的倍数时, 蛇身长增加                                                                      |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                          {Head}{Body}{Body}                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数: 00003                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页3共4");

                }
                if (i == 4E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当分数为3的倍数时, 蛇身长增加                                                                      |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                        {Head}{Body}{Body}                               |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                分数: 00003                                                                         |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页3共4");
                    i = 0;
                }

                i++;
            }

            Thread.Sleep(250);
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
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |    {Head}{Body}{Body}                                                   |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                }
                if (i == 2E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |  {Head}{Body}{Body}                                                     |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                }
                if (i == 3E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |{Head}{Body}{Body}                                                       |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                }
                if (i == 4E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                          Game Over                          |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                    Thread.Sleep(100);
                }
                if (i == 5E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                      {Body}{Body}{Body}{Body}{Body}                             |                     |");
                    Console.WriteLine($"|                |                      {Body}    {Head}{Body}                             |                     |");
                    Console.WriteLine($"|                |                      {Body}                                     |                     |");
                    Console.WriteLine($"|                |                      {Body}                                     |                     |");
                    Console.WriteLine($"|                |                      {Body}                                     |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                }
                if (i == 6E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                      {Body}{Body}{Body}{Body}{Body}                             |                     |");
                    Console.WriteLine($"|                |                      {Body}  {Head}{Body}{Body}                             |                     |");
                    Console.WriteLine($"|                |                      {Body}                                     |                     |");
                    Console.WriteLine($"|                |                      {Body}                                     |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                }
                if (i == 7E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine($"|                |                      {Body}{Body}{Body}{Body}{Body}                             |                     |");
                    Console.WriteLine($"|                |                      {Body}{Head}{Body}{Body}{Body}                             |                     |");
                    Console.WriteLine($"|                |                      {Body}                                     |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                }
                if (i == 8E6)
                {
                    Console.Clear();
                    Console.WriteLine("教程");
                    Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 当蛇头碰到边界或蛇身时, 游戏结束                                                                   |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("|                +-------------------------------------------------------------+                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                                                             |                     |");
                    Console.WriteLine("|                |                          Game Over                          |                     |");
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
                    Console.WriteLine("按下Enter键以进入下一页, Esc键以退出                                                            页4共4");
                    Thread.Sleep(100);
                    i = 0;
                }

                i++;
            }

            Thread.Sleep(250);
            Console.Clear();
            Console.WriteLine("教程");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                        现在, 尽情享受Snake吧!                                                      |");
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
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------+");
            Console.Write("请按任意键继续. . .");
            Console.ReadKey();
            return;
        }
    }
}
