using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Snake_by_JtH
{
    class Settings
    {
        static void ColorSettings()
        {
            // 仅在Windows平台上支持颜色设置
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                while (true)
                {
                    // 显示颜色设置菜单
                    Console.Clear();
                    Console.WriteLine("设置/颜色设置");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|     1 = 黑色       9 = 灰色                                                                        |");
                    Console.WriteLine("|     2 = 蓝色       A = 淡蓝色                                                                      |");
                    Console.WriteLine("|     3 = 绿色       B = 淡绿色                                                                      |");
                    Console.WriteLine("|     4 = 浅绿色     C = 淡浅绿色                                                                    |");
                    Console.WriteLine("|     5 = 红色       D = 淡红色                                                                      |");
                    Console.WriteLine("|     6 = 紫色       E = 淡紫色                                                                      |");
                    Console.WriteLine("|     7 = 黄色       F = 淡黄色                                                                      |");
                    Console.WriteLine("|     8 = 白色       G = 亮白色                                                                      |");
                    Console.WriteLine("|                                                                                                    |");
                    Console.WriteLine("| 0.返回                                                                                             |");

                    for (Int32 i = 0; i < 15; ++i)
                    {
                        Console.WriteLine("|                                                                                                    |");
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("按下对应键以选择");
                    Char Key = (Char)Console.ReadKey(true).Key;

                    // 根据用户输入更改控制台颜色
                    if (Key == '1')
                    {
                        Process.Start("cmd.exe", "/c color 07");
                    }
                    else if (Key == '2')
                    {
                        Process.Start("cmd.exe", "/c color 17");
                    }
                    else if (Key == '3')
                    {
                        Process.Start("cmd.exe", "/c color 27");
                    }
                    else if (Key == '4')
                    {
                        Process.Start("cmd.exe", "/c color 30");
                    }
                    else if (Key == '5')
                    {
                        Process.Start("cmd.exe", "/c color 47");
                    }
                    else if (Key == '6')
                    {
                        Process.Start("cmd.exe", "/c color 57");
                    }
                    else if (Key == '7')
                    {
                        Process.Start("cmd.exe", "/c color 60");
                    }
                    else if (Key == '8')
                    {
                        Process.Start("cmd.exe", "/c color 70");
                    }
                    else if (Key == '9')
                    {
                        Process.Start("cmd.exe", "/c color 87");
                    }
                    else if (Key == 'A' || Key == 'a')
                    {
                        Process.Start("cmd.exe", "/c color 90");
                    }
                    else if (Key == 'B' || Key == 'b')
                    {
                        Process.Start("cmd.exe", "/c color A0");
                    }
                    else if (Key == 'C' || Key == 'c')
                    {
                        Process.Start("cmd.exe", "/c color B0");
                    }
                    else if (Key == 'D' || Key == 'd')
                    {
                        Process.Start("cmd.exe", "/c color C7");
                    }
                    else if (Key == 'E' || Key == 'e')
                    {
                        Process.Start("cmd.exe", "/c color D7");
                    }
                    else if (Key == 'F' || Key == 'f')
                    {
                        Process.Start("cmd.exe", "/c color E0");
                    }
                    else if (Key == 'G' || Key == 'g')
                    {
                        Process.Start("cmd.exe", "/c color F0");
                    }
                    else if (Key == '0')
                    {
                        break;
                    }
                }
            }
            else
            {
                // 非Windows系统显示不支持消息
                Console.Clear();
                Console.WriteLine("设置/颜色设置");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("|                                                                                                    |");
                Console.WriteLine("|     错误：本功能暂不支持非Windows系统                                                                 |");
                
                for (Int32 i = 0; i < 22; ++i)
                {
                    Console.WriteLine("|                                                                                                    |");
                }

                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.Write("请按任意键继续. . .");
                Console.ReadKey();
                return;
            }

            return;
        }

        static void About()
        {
            Console.Clear();
            Console.WriteLine("设置/关于Snake");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                                                                                                    |");
            Console.WriteLine("|                         ___                                                                        |");
            Console.WriteLine("|                        /   \\            |                                                          |");
            Console.WriteLine("|                        \\___             |    __                                                    |");
            Console.WriteLine("|                            \\ |--\\   --| |/  /  \\                                                   |");
            Console.WriteLine("|                            | |   | /  | |\\  |--/                                                   |");
            Console.WriteLine("|                        \\---/ |   | \\__| | \\ \\__                                                    |");
            Console.WriteLine("|      Snake V0.1.0                                                                                  |");
            Console.WriteLine("|                by JtH                                                                              |");
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
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.Write("请按任意键继续. . .");
            Console.ReadKey();
            return;
        }

        static void SpeedSettings()
        {
            // TODO: 实现速度设置功能
            while (true)
            {
                
            }
        }

        public static void MainSettings()
        {
            while (true)
            {
                // 显示设置主菜单
                Console.Clear();
                Console.WriteLine("设置");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| 1.颜色设置                                                                                         |");
                Console.WriteLine("| 2.关于                                                                                             |");
                Console.WriteLine("|                                                                                                    |");
                Console.WriteLine("| 0.返回                                                                                             |");
                
                for (Int32 i = 0; i < 21; i++)
                {
                    Console.WriteLine("|                                                                                                    |");
                }

                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("按下对应数字键以进入");
                Char Key = (Char)Console.ReadKey(true).Key;

                // 根据用户输入进入相应的设置选项
                if (Key == '1')
                {
                    ColorSettings();
                }
                else if (Key == '2')
                {
                    About();
                }
                else if (Key == '0')
                {
                    break;
                }
            }

            return;
        }
    }
}