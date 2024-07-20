using System;
using System.IO;

namespace Snake_by_JtH
{
    class Program
    {
        // ��Ϸ�汾
        public static String Version = "";
        // ��Ϸ�ٶ�����,ֵԽС��ϷԽ��
        public static Int32 Speed = 10000;
        // �Ƿ�ʹ��Unicode�ַ�
        public static Boolean Unicode = true;

        static void Main(String[] args)
        {
            // ���Զ�ȡVERSION�ļ���д��Version����
            try
            {
                Version = File.ReadAllText(@"./VERSION");
            }
            catch { }


            // ���Settings�ļ����Ƿ����,�������򴴽�
            if (!File.Exists(@"./Settings/"))
            {
                DirectoryInfo DI = Directory.CreateDirectory(@"./Settings/");
            }

            // ���Speed�ļ��Ƿ����,�������򴴽�
            if (!File.Exists(@"./Settings/Speed"))
            {
                File.WriteAllText(@"./Settings/Speed", "10000");
            }

            // ��ȡSpeed�ļ���д��Speed����
            Speed = Convert.ToInt32(File.ReadAllText(@"./Settings/Speed"));

            // ���ÿ���̨��������ع��
            Console.Title = "Snake";
            Console.CursorVisible = false;

            // ����Ϸѭ��
            while (true)
            {
                // ��ʾ���˵�����ȡ�û�ѡ��
                Int32 n = Menu.MainMenu();

                if (n == 0)
                {
                    break; // �˳���Ϸ
                }
                else if (n == 1)
                {
                    // ��ʼ����Ϸ
                    Int32 score = Game.MainGame();
                    Fail.MainFail(score);
                }
                else if (n == 2)
                {
                    // �������ò˵�
                    Settings.MainSettings();
                }
            }

            return;
        }
    }
}
