//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    class Class8
//    {
//        static int[,] grid = new int[99,99];
//        static int x = 0;
//        static int y = 0;
//        static int tmpResult = 0;
//        static int result = 0;
//        static int resultP2 = 0;
//        static void Main()
//        {
//            string textfile = @"textfile8.txt";
//            string[] lines = File.ReadAllLines(textfile);
//            for(int y = 0; y < lines.Length; y++)
//            {
//                for(int x = 0; x < lines[y].Length; x++)
//                {
//                    grid[x,y] = lines[y][x];
//                }
//            }

//            Console.WriteLine(grid[1, 1] - 48);

//            for (int k = 0; k<99; k++)
//            {
//                for(int l=0; l<99; l++)
//                {
//                    /*if(grid[l,k] < grid[l + 1, k])
//                    {
//                        Console.WriteLine("Chiffre {0} dans la case {1} {2}", grid[l, k], l, k);
//                        Console.WriteLine("Chiffre {0} dans la case {1} {2}", grid[l+1, k], l+1, k);
//                    }*/

//                    /*if (CheckTop(l, k, grid[l, k]))
//                    {
//                        result++;
//                    }else if (CheckBot(l, k, grid[l, k]))
//                    {
//                        result++;
//                    }
//                    else if (CheckLeft(k, l, grid[l, k]))
//                    {
//                        result++;
//                    }
//                    else if (CheckRight(k, l, grid[l, k]))
//                    {
//                        result++;
//                    }*/
//                    int tmp1 = CheckTopP2(l, k, grid[l, k]);
//                    int tmp2 = CheckBotP2(l, k, grid[l, k]);
//                    int tmp3 = CheckRightP2(k, l, grid[l, k]);
//                    int tmp4 = CheckLeftP2(k, l, grid[l, k]);

//                    int tmpResult2 = CheckTopP2(l, k, grid[l, k]) * CheckBotP2(l, k, grid[l, k]) * CheckLeftP2(k, l, grid[l, k]) * CheckRightP2(k, l, grid[l, k]);

//                    tmpResult = tmp1 * tmp2 * tmp3 * tmp4;

//                    /*if (l == 10 && k == 10)
//                    {
//                        Console.WriteLine("Chiffre {0} dans la case {1} {2}", grid[l, k], l, k);
//                        Console.WriteLine("Top:{0} Bot:{1} Left:{2} Right:{3}", CheckTopP2(l, k, grid[l, k]), CheckBotP2(l, k, grid[l, k]), CheckLeftP2(k, l, grid[l, k]), CheckRightP2(k, l, grid[l, k]));
//                    }*/
//                    if (tmpResult > resultP2)
//                    {
//                        Console.WriteLine(tmpResult);
//                        Console.WriteLine(tmpResult2);
//                        onsole.WriteLine(tmpResult);
//                        Console.WriteLine("Chiffre {0} dans la case {1} {2}", grid[l, k], l, k);
//                        Console.WriteLine("Top:{0} Bot:{1} Left:{2} Right:{3}", CheckTopP2(l, k, grid[l, k]), CheckBotP2(l, k, grid[l, k]), CheckLeftP2(k, l, grid[l, k]), CheckRightP2(k, l, grid[l, k]));
//                        resultP2 = tmpResult;
//                    }
//                    Console.WriteLine(tmpResult);

//                }
//            }
//            /*Console.WriteLine(grid[10, 10] - 48);
//            for (int t = 0; t < 10; t++)
//            {
//                for (int y = 0; y < 10; y++)
//                {
//                    Console.Write(grid[y, t]-48);
//                }
//                Console.WriteLine();
//            }*/

//            Console.WriteLine(resultP2);
//            Console.ReadLine();
//        }

//        private static bool CheckTop(int x, int startY, int c)
//        {
//            for (var y = startY - 1; y >= 0; y--)
//            {
//                if (c <= grid[x,y])
//                {
//                    return false;
//                }
//            }

//            return true;
//        }

//        private static bool CheckBot(int x, int startY, int c)
//        {
//            for (var y = startY + 1; y <= 98; y++)
//            {
//                if (c <= grid[x, y])
//                {
//                    return false;
//                }
//            }

//            return true;
//        }

//        private static bool CheckLeft(int y, int startX, int c)
//        {
//            for (var x = startX - 1; x >= 0; x--)
//            {
//                if (c <= grid[x, y])
//                {
//                    return false;
//                }
//            }

//            return true;
//        }

//        private static bool CheckRight(int y, int startX, int c)
//        {
//            for (var x = startX + 1; x <= 98; x++)
//            {
//                if (c <= grid[x, y])
//                {
//                    return false;
//                }
//            }

//            return true;
//        }

//        private static int CheckTopP2(int x, int startY, int c)
//        {
//            for (var y = startY - 1; y >= 0; y--)
//            {
//                if (c <= grid[x, y])
//                {
//                    return startY - y;
//                }
//            }
//            return startY;
//        }
//        private static int CheckBotP2(int x, int startY, int c)
//        {
//            for (var y = startY + 1; y <= 98; y++)
//            {
//                if (c <= grid[x, y])
//                {
//                    return y - startY;
//                }
//            }

//            return 98-startY;
//        }
//        private static int CheckLeftP2(int y, int startX, int c)
//        {
//            for (var x = startX - 1; x >= 0; x--)
//            {
//                if (c <= grid[x, y])
//                {
//                    return startX - x;
//                }
//            }

//            return startX;
//        }
//        private static int CheckRightP2(int y, int startX, int c)
//        {
//            for (var x = startX + 1; x <= 98; x++)
//            {
//                if (c <= grid[x, y])
//                {
//                    return x - startX;
//                }
//            }

//            return 98 - startX;
//        }
        
//    }
//}
