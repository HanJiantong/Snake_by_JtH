using System;

namespace Snake_by_JtH
{
    class Game
    {
        public static Int32 MainGame()
        {
            Int16[,] List = new Int16[26, 51];
            Int16 Direction = 0, Length = 2, Score = 0;
            List[12, 24] = 2;
            List[13, 24] = 1;
            Boolean Alive = true;
            Int16 Head_i = 12, Head_j = 24;
            Int16 Food_i = -1, Food_j = -1;
            Boolean Length_changed = false;
            Int16 k = 0;

            while (Alive)
            {
                k++;

                if (Food_i == -1 && Food_j == -1)
                {
                    Food_i = (Int16)new Random().Next(2, 23);
                    Food_j = (Int16)new Random().Next(2, 48);
                }

                if (k == Program.Speed)
                {
                    k = 0;
                    Console.Clear();
                    Console.Write("游戏\n------------------------------------------------------------------------------------------------------\n");

                    for (Int16 i = 0; i < 25; i++)
                    {
                        Console.Write("|");

                        for (Int16 j = 0; j < 50; j++)
                        {
                            if (i == Food_i && j == Food_j)
                            {
                                if (List[i, j] > 0)
                                {
                                    Food_i = -1;
                                    Food_j = -1;
                                    Score++;
                                    Console.Beep();
                                }
                                else
                                {
                                    if (Program.Unicode)
                                    {
                                        Console.Write("■ ");
                                    }
                                    else
                                    {
                                        Console.Write("~ ");
                                    }
                                }
                            }

                            if (List[i, j] == Length)
                            {
                                if (Length_changed)
                                {
                                    ++List[i, j];
                                }

                                Head_i = i;
                                Head_j = j;
                                if (Program.Unicode)
                                {
                                    Console.Write("██");
                                }
                                else
                                {
                                    Console.Write("><");
                                }
                                List[i, j]--;
                            }
                            else if (List[i, j] > 0 && List[i, j] < Length)
                            {
                                if (Length_changed)
                                {
                                    List[i, j]++;
                                }

                                Console.Write("[]");
                                List[i, j]--;
                            }
                            else if (!(i == Food_i && j == Food_j))
                            {
                                Console.Write("  ");
                            }
                        }

                        Console.Write("|\n");
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("分数：{0}", Score.ToString("D5"));

                    if (Direction == 0)
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
                    else if (Direction == 1)
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
                    else if (Direction == 2)
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
                    else if (Direction == 3)
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

                    if (Score / 3 > Length - 2)
                    {
                        ++Length;
                        Length_changed = true;
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if ((key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W) && Direction != 2)
                    {
                        Direction = 0;
                    }
                    else if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && Direction != 3)
                    {
                        Direction = 1;
                    }
                    else if ((key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S) && Direction != 0)
                    {
                        Direction = 2;
                    }
                    else if ((key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D) && Direction != 1)
                    {
                        Direction = 3;
                    }
                }
            }

            return Score;
        }
    }
}
