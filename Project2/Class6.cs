//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    class Class6
//    {
//        static char test;
//        static string result = "";
//        static int rep;
//        static void Main()
//        {
//            string textfile = @"textfile6.txt";
//            string input = File.ReadAllText(textfile);
//            for (int i = 0; i < input.Length; i++)
//            {
//                test = input[i];
//                if (result.Length == 14)
//                {
//                    rep = i;
//                    break;
//                }
//                if (!result.Contains(test))
//                {
//                    result += test;
//                }
//                else
//                {
//                    result = "";
//                }
//            }
//            Console.WriteLine(rep);
//            Console.ReadLine();
//        }
//    }
//}
