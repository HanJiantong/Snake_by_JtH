using System;
using System.IO;

namespace Snake_by_JtH
{
    class Program
    {
        // 游戏版本
        public static String Version = "";
        // 游戏速度设置,值越小游戏越快
        public static Int32 Speed = 8000;
        // 是否使用Unicode字符
        public static Boolean Unicode = true;
        // 是否是第一次启动
        public static Boolean FirstStart = false;

        static void Main(String[] args)
        {
            // 尝试读取VERSION文件并写入Version变量
            try
            {
                Version = File.ReadAllText(@"./VERSION");
            }
            catch { }


            // 检查Settings文件夹是否存在,不存在则创建
            if (!File.Exists(@"./Settings/"))
            {
                Directory.CreateDirectory(@"./Settings/");
            }

            // 检查Speed文件是否存在,不存在则创建
            if (!File.Exists(@"./Settings/Speed"))
            {
                File.WriteAllText(@"./Settings/Speed", "10000");
            }
            // 检查Unicode文件是否存在,不存在则创建
            if (!File.Exists(@"./Settings/Unicode"))
            {
                File.WriteAllText(@"./Settings/Unicode", "true");
                FirstStart = true;
            }

            // 读取Speed文件并写入Speed变量
            Speed = Convert.ToInt32(File.ReadAllText(@"./Settings/Speed"));
            // 读取Unicode文件并写入Unicode变量
            Unicode = File.ReadAllText(@"./Settings/Unicode") == "true";

            // 设置控制台标题和隐藏光标
            Console.Title = "Snake";
            Console.CursorVisible = false;

            Start.MainStart();

            // 主游戏循环
            while (true)
            {
                // 显示主菜单并获取用户选择
                Int32 n = Menu.MainMenu();
                
                if (n == 49)
                {
                    // 开始新游戏
                    Int32 Score = Game.MainGame();
                    Fail.MainFail(Score);
                }
                else if (n == 50)
                {
                    // 进入设置菜单
                    Settings.MainSettings();
                }
                if (n == 27)
                {
                    break; // 退出游戏
                }
            }

            return;
        }
    }
}
