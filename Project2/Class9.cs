//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Contracts;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    class Class9
//    {
//        static int[,] grid = new int[1000, 1000];
//        static int headX;
//        static int headY;
//        static int tailX;
//        static int tailY;

//        static int distX;
//        static int distY;

//        static char dir;
//        static string rep;

//        static int result;
//        static int pdd = 500;
//        public struct Coords
//        {
//            public Coords(int x, int y)
//            {
//                X = x;
//                Y = y;
//            }
//            public int X { get; set; }
//            public int Y { get; set; }
//        }

//        //static Coords un = new Coords(500,500);
//        //static Coords deux = new Coords(500, 500);
//        //static Coords trois = new Coords(500, 500);
//        //static Coords quatre = new Coords(500, 500);
//        //static Coords cinq = new Coords(500, 500);
//        //static Coords six = new Coords(500, 500);
//        //static Coords sept = new Coords(500, 500);
//        //static Coords huit = new Coords(500, 500);
//        //static Coords neuf = new Coords(500, 500);
//        //static Coords head = new Coords(500, 500);

//        static void Main()
//        {
//            string textfile = @"textfile9.txt";
//            string[] lines = File.ReadAllLines(textfile);

//            headX = 500;
//            headY = 500;
//            tailX = 500;
//            tailY = 500;

//            Coords un = new Coords(500, 500);
//            Coords deux = new Coords(500, 500);
//            Coords trois = new Coords(500, 500);
//            Coords quatre = new Coords(500, 500);
//            Coords cinq = new Coords(500, 500);
//            Coords six = new Coords(500, 500);
//            Coords sept = new Coords(500, 500);
//            Coords huit = new Coords(500, 500);
//            Coords neuf = new Coords(500, 500);
//            Coords head = new Coords(500, 500);



//            foreach (string line in lines)
//            {
//                dir = line[0];

//                for (int i = 2; i < line.Length; i++)
//                {
//                    rep += line[i];
//                }
//                for (int j = 0; j < Int64.Parse(rep); j++)
//                {
//                    //Move Head
//                    if (dir == 'U') //Up y+1
//                    {
//                        //headY++;
//                        head.Y++;
//                    }
//                    else if (dir == 'D') //Down y-1
//                    {
//                        //headY--;
//                        head.Y--;
//                    }
//                    else if (dir == 'R') //Right x+1
//                    {
//                        //headX++;
//                        head.X++;
//                    }
//                    else if (dir == 'L') //Left x-1
//                    {
//                        //headX--;
//                        head.X--;
//                    }

//                    #region P1
//                    //Faire un struc de vector2
//                    //Faire une focntion avec ce qu'il y a en desssous avec 2 argument celui qui suit et celui qui doit suivre 1 to H, 2 to 1, 3 to 2 ect on peut meme faire un dico
//                    //Move Tail
//                    //grid[tailX, tailY] = 1;
//                    //distX = Math.Abs(headX - tailX);
//                    //distY = Math.Abs(headY - tailY);
//                    ////Console.WriteLine("Tete:{0},{1} Tail: {2},{3}, action N:{4}, distX:{5}, distY:{6}", headX, headY, tailX, tailY, j , distX, distY);
//                    //if (distX >=2 || distY >= 2)
//                    //{
//                    //    if(distX >= 2 && distY >= 1 || distX >= 1 && distY >=2)
//                    //    {
//                    //        if(headY < tailY && headX > tailX) //Tete en haut a droite
//                    //        {
//                    //            tailX++;
//                    //            tailY--;
//                    //           //Console.Write("Haut droite");
//                    //        }
//                    //        else if(headY < tailY && headX < tailX) //Tete en haut a gauche
//                    //        {
//                    //            tailX--;
//                    //            tailY--;
//                    //           //Console.Write("Haut gauche");
//                    //        }
//                    //        else if (headY > tailY && headX < tailX) //Tete en bas a gauche
//                    //        {
//                    //            tailX--;
//                    //            tailY++;
//                    //           //Console.Write("Bas gauche");
//                    //        }
//                    //        else if (headY > tailY && headX > tailX) //Tete en bas a droite
//                    //        {
//                    //            tailX++;
//                    //            tailY++;
//                    //           //Console.Write("Bas Droite");
//                    //        }
//                    //    }
//                    //    else if(distX >= 2 && headY == tailY)
//                    //    {
//                    //        if(headX < tailX) // A gauche
//                    //        {
//                    //            tailX--;//Console.Write("gauche");
//                    //        }
//                    //        else if (headX > tailX) // A droite
//                    //        {
//                    //            tailX++;//Console.Write("Droite");
//                    //        }
//                    //    }
//                    //    else if (distY >= 2 && headX == tailX)
//                    //    {
//                    //        if (headY < tailY) // En haut
//                    //        {
//                    //            tailY--;//Console.Write("Haut");
//                    //        }
//                    //        else if (headY > tailY) // En bas
//                    //        {
//                    //            tailY++;//Console.Write("Bas");
//                    //        }
//                    //    }
//                    //}
//                    //if (distX >= 3 || distY >= 3)
//                    //{
//                    //   Console.Write("Problème Ici");
//                    //}

//                    #endregion

//                    grid[neuf.X, neuf.Y] = 1;
//                    follow(ref head, ref un);
//                    //Console.WriteLine("{0}, {1}", un.X, un.Y);
//                    follow(ref un, ref deux);
//                    follow(ref deux, ref trois);
//                    follow(ref trois, ref quatre);
//                    follow(ref quatre, ref cinq);
//                    follow(ref cinq, ref six);
//                    follow(ref six, ref sept);
//                    follow(ref sept, ref huit);
//                    follow(ref huit, ref neuf);

//                }
//                //Console.WriteLine("{0}{1}", dir, rep);
//                rep = "";
//            }

//            for (int a = 0; a < 1000; a++)
//            {
//                for (int b = 0; b < 1000; b++)
//                {
//                    if (grid[a, b] == 1)
//                    {
//                        result++;
//                    }
//                }
//            }
//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//        public static void follow(ref Coords front, ref Coords back)
//        {
//            distX = Math.Abs(front.X - back.X);
//            distY = Math.Abs(front.Y - back.Y);
//            //Console.WriteLine("Tete:{0},{1} Tail: {2},{3}, distX:{4}, distY:{5}", front.X, front.Y, back.X, back.Y, distX, distY);
//            if (distX >= 2 || distY >= 2)
//            {
//                //Console.WriteLine("move");
//                if (distX >= 2 && distY >= 1 || distX >= 1 && distY >= 2)
//                {
//                    if (front.Y < back.Y && front.X > back.X) //Tete en haut a droite
//                    {
//                        back.X++;
//                        back.Y--;
//                        //Console.Write("Haut droite");
//                    }
//                    else if (front.Y < back.Y && front.X < back.X) //Tete en haut a gauche
//                    {
//                        back.X--;
//                        back.Y--;
//                        //Console.Write("Haut gauche");
//                    }
//                    else if (front.Y > back.Y && front.X < back.X) //Tete en bas a gauche
//                    {
//                        back.X--;
//                        back.Y++;

//                        Console.WriteLine(back.Y);
//                    }
//                    else if (front.Y > back.Y && front.X > back.X) //Tete en bas a droite
//                    {
//                        back.X++;
//                        back.Y++;
//                        //Console.Write("Bas Droite");
//                    }
//                }
//                else if (distX >= 2 && front.Y == back.Y)
//                {
//                    if (front.X < back.X) // A gauche
//                    {
//                        back.X--;//Console.Write("gauche");
//                    }
//                    else if (front.X > back.X) // A droite
//                    {
//                        back.X++;//Console.Write("Droite");
//                    }
//                }
//                else if (distY >= 2 && front.X == back.X)
//                {
//                    if (front.Y < back.Y) // En haut
//                    {
//                        back.Y--;//Console.Write("Haut");
//                    }
//                    else if (front.Y > back.Y) // En bas
//                    {
//                        back.Y++;//Console.Write("Bas");
//                    }
//                }
//            }
//            else Console.WriteLine("NO");
//        }
//    }
//}
