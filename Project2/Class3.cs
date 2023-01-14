//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace project2
//{
//    class testclass3
//    {
//        //Check les memes lettres et leur donner un score
//        static string one;
//        static string two;
//        static string three;
//        static int result;
//        static void Main()
//        {
//            string textfile = @"textfile3.txt";
//            string[] lines = File.ReadAllLines(textfile);
//            for (int s = 0; s < lines.Length; s += 3)
//            {
//                one = lines[s + 0];
//                two = lines[s + 1];
//                three = lines[s + 2];
//                for (int a = 0; a < one.Length; a++)
//                {
//                    for (int b = 0; b < two.Length; b++)
//                    {
//                        for (int c = 0; c < three.Length; c++)
//                        {
//                            if (one[a] == two[b] && one[a] == three[c])
//                            {
//                                if (char.IsLower(one[a]))
//                                {
//                                    result += one[a] - 'a' + 1;
//                                }
//                                else
//                                {
//                                    result += one[a] - 'A' + 27;
//                                }
//                                one = one.Replace(one[a], ' ');
//                            }
//                        }
//                    }
//                }

//                //comparechars(one, two);


//            }
//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//    }
//}
