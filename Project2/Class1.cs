//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    //Faire le top 3 des sums
//    class Class1
//    {
//        static public int[] most = new int[3];
//        static int tmp = 0;
//        static void Main()
//        {
//            string textFile = @"TextFile1.txt";
//            string[] lines = File.ReadAllLines(textFile);
//            foreach (string line in lines)
//            {
//                if (line != "")
//                {
//                    tmp += (int)Int64.Parse(line);
//                }
//                else
//                {
//                    if (tmp > most[0])
//                    {
//                        most[0] = tmp;
//                        Array.Sort(most);
//                    }
//                    tmp = 0;
//                }
//            }
//            Console.WriteLine(most[0] + most[1] + most[2]);
//            Console.ReadLine();
//        }
//    }
//}
