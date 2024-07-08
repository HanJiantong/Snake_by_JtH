using System;
using System.IO;

namespace Snake_by_JtH
{
    class Program
    {
        // 游戏速度设置,值越小游戏越快
        public static Int16 Speed = 10000;
        // 是否使用Unicode字符
        public static Boolean Unicode = true;

        static void Main(String[] args)
        {
            // 检查Speed文件是否存在,不存在则创建
            if (!File.Exists("./Speed"))
            {
                FileStream FS = File.Create("./Speed");
                FS.Close();
            }
            else
            {
                // TODO: 读取Speed文件内容
            }

            // 设置控制台标题和隐藏光标
            Console.Title = "Snake";
            Console.CursorVisible = false;

            // 主游戏循环
            while (true)
            {
                // 显示主菜单并获取用户选择
                Int32 n = Menu.MainMenu();

                if (n == 0)
                {
                    break; // 退出游戏
                }
                else if (n == 1)
                {
                    // 开始新游戏
                    Int32 score = Game.MainGame();
                    Fail.MainFail(score);
                }
                else if (n == 2)
                {
                    // 进入设置菜单
                    Settings.MainSettings();
                }
            }

            return;
        }
    }
}