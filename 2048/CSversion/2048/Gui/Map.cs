using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    class Map
    {
        // 私有属性
        // points 记录得分
        // map 为二维数组
        // randomNums 存储可以自动生成的数字
        // random 随机类实例化
        // topPoints为有记录的最高得分
        // fileName是存放topPoints的文本文件
        private int[,] map;
        private int points;
        private int topPoints;
        private readonly string fileName = @".\topPoints.txt";
        private readonly int[] randomNums = { 2, 4, 8 };
        private readonly Random random = new Random();


        public Map()
        {
            // 构造函数
            InitializeMap();
        }

        public int[,] GetMap()
        {
            // 返回Map类的map数组属性
            return map;
        }

        public int TopPoints()
        {
            // 返回topPoints属性
            return topPoints;
        }

        public int Points()
        {
            return points;
        }

        public void InitializeMap()
        {
            // 初始化类
            points = 0;
            GetTopPoints();
            map = new int[4, 4];

            // 为map随机填充一个或两个数字
            for (int i = 0; i < 2; i++)
            {
                map[random.Next(0, 3), random.Next(0, 3)] = randomNums[random.Next(0, 2)];
            }
        }

        public void GetTopPoints()
        {
            // 打开filename，并读取topPoints
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string txt = sr.ReadLine();
            if (txt == "")
            {
                topPoints = 0;
            }
            else
            {
                topPoints = Convert.ToInt32(txt);
            }
            sr.Close();
            fs.Close();
        }

        public void SetTopPoints()
        {
            // 打开filename，并写入topPoints
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            string txt = topPoints.ToString();
            sw.WriteLine(txt);
            sw.Close();
            fs.Close();
        }

        public bool ShuffleMap()
        {
            // 添加数字
            ArrayList zerosList = new ArrayList();

            // 如果points超过topPoints
            if (points > topPoints)
            {
                topPoints = points;
            }

            // 如果没有空位置（0），则判定失败，返回false
            int zeros = ZerosInMap(ref zerosList);
            if (zeros == 0)
            {
                return false;
            }
            // 随机在空位置填充随机数
            int num = random.Next(0, zeros - 1);
            int[] list = (int[])(zerosList[num]);
            map[list[0], list[1]] = randomNums[random.Next(0, 3)];

            return true;
        }

        public int ZerosInMap(ref ArrayList zerosList)
        {
            // 查看map中有多少空位置，并记录空位置的索引信息到zerosList中
            int zeros = 0;

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    if (map[row, col] == 0)
                    {
                        zeros++;
                        zerosList.Add(new int[2] { row, col });
                    }
                }
            }

            return zeros;
        }

        public void TraverseMap()
        {
            // 遍历 
            // 显示分数
            ShowPoints();

            // 遍历显示map
            // 0表示空位置，用Black黑色输出，以达到隐身的效果
            // 非空位置，用DarkCyan深紫色输出
            for (int row = 0; row < map.GetLength(0); row++)
            {
                Console.Write("\t\t[");
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    if (map[row, col] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"0, ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{map[row, col]}, ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("\b\b]");
            }
        }

        public bool ReadKey()
        {
            // 获取键盘输入
            ConsoleKeyInfo keyInfo;

            // 键盘上箭头、下箭头、左箭头、右箭头
            // 按Q键退出，返回false
            Console.Write("Please enter a key[↑、↓、←、→]（q to quit）: ");
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                UpMap();
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                DownMap();
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                LeftMap();
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                RightMap();
            }
            else if (keyInfo.Key == ConsoleKey.Q)
            {
                return false;
            }

            return true;
        }

        public void UpMap()
        {
            // 上移
            for (int col = 0; col < map.GetLength(1); col++)
            {
                for (int row = map.GetLength(0) - 1; row > 0; row--)
                {
                    if (map[row, col] == 0)
                    {
                        continue;
                    }
                    else if (map[row - 1, col] == 0)
                    {
                        for (int r = row - 1; r < map.GetLength(0) - 1; r++)
                        {
                            map[r, col] ^= map[r + 1, col];
                            map[r + 1, col] ^= map[r, col];
                            map[r, col] ^= map[r + 1, col];
                        }

                    }
                    else if (map[row, col] == map[row - 1, col])
                    {
                        map[row - 1, col] *= 2;
                        points += map[row - 1, col];
                        map[row, col] = 0;
                        for (int r = row; r < map.GetLength(0) - 1; r++)
                        {
                            map[r, col] ^= map[r + 1, col];
                            map[r + 1, col] ^= map[r, col];
                            map[r, col] ^= map[r + 1, col];
                        }
                    }
                }
            }
        }

        public void DownMap()
        {
            // 下移
            for (int col = 0; col < map.GetLength(1); col++)
            {
                for (int row = 0; row < map.GetLength(0) - 1; row++)
                {
                    if (map[row, col] == 0)
                    {
                        continue;
                    }
                    else if (map[row + 1, col] == 0)
                    {
                        for (int r = row + 1; r > 0; r--)
                        {
                            map[r - 1, col] ^= map[r, col];
                            map[r, col] ^= map[r - 1, col];
                            map[r - 1, col] ^= map[r, col];
                        }
                    }
                    else if (map[row, col] == map[row + 1, col])
                    {
                        map[row + 1, col] *= 2;
                        points += map[row + 1, col];
                        map[row, col] = 0;
                        for (int r = row; r > 0; r--)
                        {
                            map[r - 1, col] ^= map[r, col];
                            map[r, col] ^= map[r - 1, col];
                            map[r - 1, col] ^= map[r, col];
                        }
                    }
                }
            }
        }

        public void LeftMap()
        {
            // 左移
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = map.GetLength(1) - 1; col > 0; col--)
                {
                    if (map[row, col] == 0)
                    {
                        continue;
                    }
                    else if (map[row, col - 1] == 0)
                    {
                        for (int c = col - 1; c < map.GetLength(1) - 1; c++)
                        {
                            map[row, c] ^= map[row, c + 1];
                            map[row, c + 1] ^= map[row, c];
                            map[row, c] ^= map[row, c + 1];
                        }
                    }
                    else if (map[row, col] == map[row, col - 1])
                    {
                        map[row, col - 1] *= 2;
                        points += map[row, col - 1];
                        map[row, col] = 0;
                        for (int c = col; c < map.GetLength(1) - 1; c++)
                        {
                            map[row, c] ^= map[row, c + 1];
                            map[row, c + 1] ^= map[row, c];
                            map[row, c] ^= map[row, c + 1];
                        }
                    }
                }
            }
        }

        public void RightMap()
        {
            // 右移
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1) - 1; col++)
                {
                    if (map[row, col] == 0)
                    {
                        continue;
                    }
                    else if (map[row, col + 1] == 0)
                    {
                        for (int c = col + 1; c > 0; c--)
                        {
                            map[row, c - 1] ^= map[row, c];
                            map[row, c] ^= map[row, c - 1];
                            map[row, c - 1] ^= map[row, c];
                        }
                    }
                    else if (map[row, col] == map[row, col + 1])
                    {
                        map[row, col + 1] *= 2;
                        points += map[row, col + 1];
                        map[row, col] = 0;
                        for (int c = col; c > 0; c--)
                        {
                            map[row, c - 1] ^= map[row, c];
                            map[row, c] ^= map[row, c - 1];
                            map[row, c - 1] ^= map[row, c];
                        }
                    }
                }
            }
        }

        public void ExitMap()
        {
            // 退出
            Console.WriteLine("See you next time!");
        }

        public void FailMap()
        {
            // 失败
            Console.WriteLine("Sorry, you failed!");
        }

        public void ShowPoints()
        {
            if (points > topPoints)
                topPoints = points;
            // 显示分数
            Console.WriteLine($"{points} Points!\t\tTop Score: {topPoints}");
        }
    }
}
