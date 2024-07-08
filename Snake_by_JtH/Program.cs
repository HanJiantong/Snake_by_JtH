using System;
using System.IO;

namespace Snake_by_JtH
{
    class Program
    {
        // ��Ϸ�ٶ�����,ֵԽС��ϷԽ��
        public static Int16 Speed = 10000;
        // �Ƿ�ʹ��Unicode�ַ�
        public static Boolean Unicode = true;

        static void Main(String[] args)
        {
            // ���Speed�ļ��Ƿ����,�������򴴽�
            if (!File.Exists("./Speed"))
            {
                FileStream FS = File.Create("./Speed");
                FS.Close();
            }
            else
            {
                // TODO: ��ȡSpeed�ļ�����
            }

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