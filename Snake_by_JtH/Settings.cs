using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Snake_by_JtH
{
    class Settings
    {
        static void ColorSettings()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("����/��ɫ����");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("|     1 = ��ɫ       9 = ��ɫ                                                                        |");
                Console.WriteLine("|     2 = ��ɫ       A = ����ɫ                                                                      |");
                Console.WriteLine("|     3 = ��ɫ       B = ����ɫ                                                                      |");
                Console.WriteLine("|     4 = ǳ��ɫ     C = ��ǳ��ɫ                                                                    |");
                Console.WriteLine("|     5 = ��ɫ       D = ����ɫ                                                                      |");
                Console.WriteLine("|     6 = ��ɫ       E = ����ɫ                                                                      |");
                Console.WriteLine("|     7 = ��ɫ       F = ����ɫ                                                                      |");
                Console.WriteLine("|     8 = ��ɫ       G = ����ɫ                                                                      |");
                Console.WriteLine("|                                                                                                    |");
                Console.WriteLine("| 0.����                                                                                             |");

                for (Int32 i = 0; i < 15; ++i)
                {
                    Console.WriteLine("|                                                                                                    |");
                }

                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("���¶�Ӧ����ѡ��");
                Char Key = (Char)Console.ReadKey(true).Key;

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
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
                }
                else
                {
                    if (Key == '1')
                    {
                        Console.Write("\033[37m\033[40m");
}
                    else if (Key == '2')
                    {
                        Console.Write("\033[37m\033[44m");
                    }
                    else if (Key == '3')
                    {
                        Console.Write("\033[37m\033[42m");
                    }
                    else if (Key == '4')
                    {
                        Console.Write("\033[30m\033[102m");
                    }
                    else if (Key == '5')
                    {
                        Console.Write("\033[37m\033[41m");
                    }
                    else if (Key == '6')
                    {
                        Console.Write("\033[37m\033[45m");
                    }
                    else if (Key == '7')
                    {
                        Console.Write("\033[30m\033[103m");
                    }
                    else if (Key == '8')
                    {
                        Console.Write("\033[30m\033[107m");
                    }
                    else if (Key == '9')
                    {
                        Console.Write("\033[37m\033[37m");
                    }
                    else if (Key == 'A' || Key == 'a')
                    {
                        Console.Write("\033[37m\033[104m");
                    }
                    else if (Key == 'B' || Key == 'b')
                    {
                        Console.Write("\033[37m\033[46m");
                    }
                    else if (Key == 'C' || Key == 'c')
                    {
                        Console.Write("\033[37m\033[106m");
                    }
                    else if (Key == 'D' || Key == 'd')
                    {
                        Console.Write("\033[37m\033[101m");
                    }
                    else if (Key == 'E' || Key == 'e')
                    {
                        Console.Write("\033[37m\033[105m");
                    }
                    else if (Key == 'F' || Key == 'f')
                    {
                        Console.Write("\033[37m\033[102m");
                    }
                    else if (Key == 'G' || Key == 'g')
                    {
                        Console.Write("\033[30m\033[107m");
                    }
                }

                if (Key == '0')
                {
                    break;
                }
            }

            return;
        }

        static void About()
        {
            Console.Clear();
            Console.WriteLine("����/����Snake");
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
            Console.Write("�밴���������. . .");
            Console.ReadKey();
            return;
        }

        public static void MainSettings()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("����");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| 1.��ɫ����                                                                                         |");
                Console.WriteLine("| 2.����                                                                                             |");
                Console.WriteLine("|                                                                                                    |");
                Console.WriteLine("| 0.����                                                                                             |");
                
                for (Int32 i = 0; i < 21; i++)
                {
                    Console.WriteLine("|                                                                                                    |");
                }

                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("���¶�Ӧ���ּ��Խ���");
                Char Key = (Char)Console.ReadKey(true).Key;

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