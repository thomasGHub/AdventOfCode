//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    class Class5
//    {
//        static string one = "BWN";
//        static string two = "LZSPTDMB";
//        static string three = "QHZWR";
//        static string four = "WDVJZR";
//        static string five = "SHMB";
//        static string six = "LGNJHVPB";
//        static string seven = "JQZFHDLS";
//        static string height = "WSFJGQB";
//        static string nine = "ZWMSCDJ";
//        static string order1;
//        static string order2;
//        static string order3;
//        static string order4;

//        static Dictionary<string, string> map = new Dictionary<string, string>();
//        static void Main()
//        {
//            map.Add("1", one);
//            map.Add("2", two);
//            map.Add("3", three);
//            map.Add("4", four);
//            map.Add("5", five);
//            map.Add("6", six);
//            map.Add("7", seven);
//            map.Add("8", height);
//            map.Add("9", nine);

//            string textfile = @"textfile5.txt";
//            string[] lines = File.ReadAllLines(textfile);
//            foreach (string line in lines)
//            {
//                int startIndex = 5;
//                int length = 2;
//                order1 = line.Substring(startIndex, length);
//                if (order1[1] == ' ')
//                {
//                    order1 = order1.Remove(1, 1);
//                }
//                int startIndex2 = 12;
//                int length2 = 2;
//                order2 = line.Substring(startIndex2, length2);
//                if (order2[0] == ' ')
//                {
//                    order2 = order2.Remove(0, 1);
//                }
//                if(order2.Length == 2 && order2[1] == ' ')
//                {
//                    order2 = order2.Remove(1, 1);
//                }
                
//                int startIndex3 = line.Length-1;
//                int length3 = 1;
//                order3 = line.Substring(startIndex3, length3);

//                for (int i = 0; i < (int)Int64.Parse(order1); i++)
//                {
//                    //map[order3] += map[order2][map[order2].Length - 1];
//                    //map[order2] = map[order2].Remove(map[order2].Length - 1, 1);

//                    //Part2
//                    order4 = map[order2][map[order2].Length - 1] + order4;
//                    map[order2] = map[order2].Remove(map[order2].Length - 1, 1);

//                }
//                //Console.WriteLine(order4);
//                map[order3] += order4;
//                order4 = "";
//            }
//            Console.WriteLine(map["1"]);
//            Console.WriteLine(map["2"]);
//            Console.WriteLine(map["3"]);
//            Console.WriteLine(map["4"]);
//            Console.WriteLine(map["5"]);
//            Console.WriteLine(map["6"]);
//            Console.WriteLine(map["7"]);
//            Console.WriteLine(map["8"]);
//            Console.WriteLine(map["9"]);
//            Console.ReadLine();
//        }
//    }
//}