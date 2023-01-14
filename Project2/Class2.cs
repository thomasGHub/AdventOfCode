//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    class Class2
//    {
//        // A X Rock 1
//        // B Y Paper 2 
//        // C Z Scisssors 3
//        //Loose 0 Draw 3 Win 6
//        //PArt 2 : X = loose Y = Draw Z = Win
//        static char p1;
//        static char p2;
//        static int result = 0;
//        static void Main()
//        {
//            string textFile = @"TextFile2.txt";
//            string[] lines = File.ReadAllLines(textFile);
//            foreach (string line in lines)
//            {
//                p1 = line[0];
//                p2 = line[2];
//                if (p1 == 'A' && p2 == 'X')
//                {
//                    //result += 1 + 3;
//                    result += 0 + 3;
//                }
//                if (p1 == 'A' && p2 == 'Y')
//                {
//                    //result += 2 + 6;
//                    result += 3 + 1;
//                }
//                if (p1 == 'A' && p2 == 'Z')
//                {
//                    //result += 3 + 0;
//                    result += 6 + 2;
//                }
//                if (p1 == 'B' && p2 == 'X')
//                {
//                    //result += 1 + 0;
//                    result += 0 + 1;
//                }
//                if (p1 == 'B' && p2 == 'Y')
//                {
//                    //result += 2 + 3;
//                    result += 3 + 2;
//                }
//                if (p1 == 'B' && p2 == 'Z')
//                {
//                    //result += 3 + 6;
//                    result += 6 + 3;
//                }
//                if (p1 == 'C' && p2 == 'X')
//                {
//                    //result += 1 + 6;
//                    result += 0 + 2;
//                }
//                if (p1 == 'C' && p2 == 'Y')
//                {
//                    //result += 2 + 0;
//                    result += 3 + 3;
//                }
//                if (p1 == 'C' && p2 == 'Z')
//                {
//                    //result += 3 + 3;
//                    result += 6 + 1;
//                }
//            }
//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//    }
//}

