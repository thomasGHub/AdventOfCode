//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace project2
//{
//    class testclass4
//    {
//        static int result = 0;
//        static string first;
//        static string second;
//        static string third;
//        static string fourth;
//        static bool firstBool = false;
//        static bool secondBool = false;
//        static bool thirdBool = false;
//        static bool fourthBool = false;
//        static int un;
//        static int deux;
//        static int trois;
//        static int quatre;
//        static int tmp;

//        static void Main()
//        {
//            string textfile = @"textfile4.txt";
//            string[] lines = File.ReadAllLines(textfile);
//            foreach(string line in lines)
//            {
//                //Séparation des chiffres Faire par split aurait été mieux
//                foreach(char c in line)
//                {
//                    if (c != '-' && !firstBool)
//                    {
//                        first += c;
//                    }else if (c =='-' && !firstBool)
//                    {
//                        firstBool = true;
//                    }

//                    else if(c !=',' && firstBool && !secondBool)
//                    {
//                        second += c;
//                    }else if(c==',' && !secondBool)
//                    {
//                        secondBool = true;
//                    }

//                    else if (c != '-' && firstBool && secondBool && !thirdBool)
//                    {
//                        third += c;
//                    }
//                    else if (c == '-' && firstBool && secondBool && !thirdBool)
//                    {
//                        thirdBool = true;
//                    }

//                    else if (c != '-' && firstBool && secondBool && thirdBool && !fourthBool)
//                    {
//                        fourth += c;
//                    }
//                    else if (c == '-' && firstBool && secondBool && thirdBool && !fourthBool)
//                    {
//                        fourthBool = false;
//                    }
//                }

//                un = (int)Int64.Parse(first);
//                deux = (int)Int64.Parse(second);
//                trois = (int)Int64.Parse(third);
//                quatre = (int)Int64.Parse(fourth);

//                /*if (un <= trois && deux >= quatre || trois <= un && quatre >= deux)
//                {
//                    result++;
//                }*/
//                if(trois >= un && trois <= deux || quatre >= un && quatre <= deux || un >= trois && un <= quatre || deux >= trois && deux <= quatre)
//                {
//                    result++;
//                }

//                first = "";
//                firstBool = false;
//                second = "";
//                secondBool = false;
//                third = "";
//                thirdBool = false;
//                fourth = "";
//                fourthBool = false;
//            }

//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//    }
//}
