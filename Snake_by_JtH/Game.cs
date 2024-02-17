using System;

namespace Snake
{
    class Game
    {
        public static Int32 MainGame()
        {
            Int16[,] list = new Int16[26, 51];
            Int16 direction = 0, longth = 2, score = 0;
            list[12, 24] = 2;
            list[13, 24] = 1;
            Boolean alive = true;
            Int16 head_i = 12, head_j = 24;
            Int16 food_i = -1, food_j = -1;
            Boolean longth_changed = false;
            Int16 k = 0;

            while (alive)
            {
                k++;

                if (food_i == -1 && food_j == -1)
                {
                    food_i = (Int16)new Random().Next(2, 23);
                    food_j = (Int16)new Random().Next(2, 48);
                }

                if (k == Program.t)
                {
                    k = 0;
                    Console.Clear();
                    Console.Write("游戏\n------------------------------------------------------------------------------------------------------\n");

                    for (Int16 i = 0; i < 25;  i++)
                    {
                        Console.Write("|");

                        for (Int16 j = 0; j < 50; j++)
                        {
                            if (i == food_i && j == food_j)
                            {
                                if (list[i, j] > 0)
                                {
                                    food_i = -1;
                                    food_j = -1;
                                    score++;
                                    Console.Beep(750, 100);
                                }
                                else
                                {
                                    Console.Write("■ ");
                                }
                            }

                            if (list[i, j] == longth)
                            {
                                if (longth_changed)
                                {
                                    ++list[i, j];
                                }

                                head_i = i;
                                head_j = j;
                                Console.Write("██");
                                list[i, j]--;
                            }
                            else if (list[i, j] > 0 && list[i, j] < longth)
                            {
                                if (longth_changed)
                                {
                                    list[i, j]++;
                                }

                                Console.Write("[]");
                                list[i, j]--;
                            }
                            else if (!(i == food_i && j == food_j))
                            {
                                Console.Write("  ");
                            }
                        }

                        Console.Write("|\n");
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("分数：{0}", score);

                    if (direction == 0)
                    {
                        if ((head_i - 1 < 0 || list[head_i - 1, head_j] != 0) && !longth_changed)
                        {
                            alive = false;
                        }
                        else
                        {
                            list[head_i - 1, head_j] = longth;
                        }
                    }
                    else if (direction == 1)
                    {
                        if ((head_j - 1 < 0 || list[head_i, head_j - 1] != 0) && !longth_changed)
                        {
                            alive = false;
                        }
                        else
                        {
                            list[head_i, head_j - 1] = longth;
                        }
                    }
                    else if (direction == 2)
                    {
                        if ((head_i + 1 > 24 || list[head_i + 1, head_j] != 0) && !longth_changed)
                        {
                            alive = false;
                        }
                        else
                        {
                            list[head_i + 1, head_j] = longth;
                        }
                    }
                    else if (direction == 3)
                    {
                        if ((head_j + 1 > 49 || list[head_i, head_j + 1] != 0) && !longth_changed)
                        {
                            alive = false;
                        }
                        else
                        {
                            list[head_i, head_j + 1] = longth;
                        }
                    }

                    longth_changed = false;

                    if (score / 3 > longth - 2)
                    {
                        ++longth;
                        longth_changed = true;
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if ((key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W) && direction != 2)
                    {
                        direction = 0;
                    }
                    else if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && direction != 3)
                    {
                        direction = 1;
                    }
                    else if ((key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S) && direction != 0)
                    {
                        direction = 2;
                    }
                    else if ((key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D) && direction != 1)
                    {
                        direction = 3;
                    }
                }
            }

            return score;
        }
    }
}
