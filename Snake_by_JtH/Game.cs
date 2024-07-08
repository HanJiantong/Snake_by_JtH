using System;

namespace Snake_by_JtH
{
    class Game
    {
        public static Int32 MainGame()
        {
            // 初始化游戏状态
            Int16[,] List = new Int16[26, 51]; // 游戏区域二维数组
            Int16 Direction = 0, Length = 2, Score = 0; // 方向, 蛇长度, 得分
            List[12, 24] = 2; // 蛇头初始位置
            List[13, 24] = 1; // 蛇身初始位置
            Boolean Alive = true; // 蛇是否存活
            Int16 Head_i = 12, Head_j = 24; // 蛇头坐标
            Int16 Food_i = -1, Food_j = -1; // 食物坐标
            Boolean Length_changed = false; // 蛇长度是否改变
            Int16 k = 0; // 用于控制游戏速度的计数器

            while (Alive)
            {
                k++;

                // 如果没有食物，随机生成新食物
                if (Food_i == -1 && Food_j == -1)
                {
                    Food_i = (Int16)new Random().Next(2, 23);
                    Food_j = (Int16)new Random().Next(2, 48);
                }

                // 根据游戏速度更新游戏状态
                if (k == Program.Speed)
                {
                    k = 0;
                    Console.Clear();
                    Console.Write("游戏\n------------------------------------------------------------------------------------------------------\n");

                    // 绘制游戏区域
                    for (Int16 i = 0; i < 25; i++)
                    {
                        Console.Write("|");

                        for (Int16 j = 0; j < 50; j++)
                        {
                            // 处理食物逻辑
                            if (i == Food_i && j == Food_j)
                            {
                                if (List[i, j] > 0)
                                {
                                    // 蛇吃到食物
                                    Food_i = -1;
                                    Food_j = -1;
                                    Score++;
                                    Console.Beep();
                                }
                                else
                                {
                                    // 绘制食物
                                    Console.Write(Program.Unicode ? "■ " : "~ ");
                                }
                            }

                            // 处理蛇头绘制
                            if (List[i, j] == Length)
                            {
                                if (Length_changed)
                                {
                                    ++List[i, j];
                                }

                                Head_i = i;
                                Head_j = j;
                                Console.Write(Program.Unicode ? "██" : "><");
                                List[i, j]--;
                            }
                            // 处理蛇身绘制
                            else if (List[i, j] > 0 && List[i, j] < Length)
                            {
                                if (Length_changed)
                                {
                                    List[i, j]++;
                                }

                                Console.Write("[]");
                                List[i, j]--;
                            }
                            // 绘制空白区域
                            else if (!(i == Food_i && j == Food_j))
                            {
                                Console.Write("  ");
                            }
                        }

                        Console.Write("|\n");
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("分数：{0}", Score.ToString("D5"));

                    // 根据方向移动蛇头，并检查是否撞墙或自身
                    if (Direction == 0) // 向上
                    {
                        if ((Head_i - 1 < 0 || List[Head_i - 1, Head_j] != 0) && !Length_changed)
                        {
                            Alive = false;
                        }
                        else
                        {
                            List[Head_i - 1, Head_j] = Length;
                        }
                    }
                    else if (Direction == 1) // 向左
                    {
                        if ((Head_j - 1 < 0 || List[Head_i, Head_j - 1] != 0) && !Length_changed)
                        {
                            Alive = false;
                        }
                        else
                        {
                            List[Head_i, Head_j - 1] = Length;
                        }
                    }
                    else if (Direction == 2) // 向下
                    {
                        if ((Head_i + 1 > 24 || List[Head_i + 1, Head_j] != 0) && !Length_changed)
                        {
                            Alive = false;
                        }
                        else
                        {
                            List[Head_i + 1, Head_j] = Length;
                        }
                    }
                    else if (Direction == 3) // 向右
                    {
                        if ((Head_j + 1 > 49 || List[Head_i, Head_j + 1] != 0) && !Length_changed)
                        {
                            Alive = false;
                        }
                        else
                        {
                            List[Head_i, Head_j + 1] = Length;
                        }
                    }

                    Length_changed = false;

                    // 每得3分增加蛇的长度
                    if (Score / 3 > Length - 2)
                    {
                        ++Length;
                        Length_changed = true;
                    }
                }

                // 处理用户输入，改变蛇的方向
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if ((key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W) && Direction != 2)
                    {
                        Direction = 0;
                    }
                    // 其他方向的输入处理类似
                }
            }

            return Score; // 返回最终得分
        }
    }
}
