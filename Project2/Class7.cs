//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project2
//{
//    class Class7
//    {
//        //Ca ne prend que les fichiers les plus loin et ca ne remonte pas pour add
//        static string testTmpNumber;
//        static long sumTmp = 0;
//        static long sum = 0;
//        static int n;
//        static bool br = false;
//        static void Main()
//        {
//            string textfile = @"textfile7.txt";
//            string[] lines = File.ReadAllLines(textfile);
//            //Console.WriteLine(lines.Length);
//            for(int i = 0; i<lines.Length ; i++)
//            {
//                if (lines[i].Contains("$ ls") && !br)
//                {
//                    for(int j = i+1 ; j < lines.Length; j++)
//                    {
//                        if (lines[j].Contains("$ ls"))
//                        {
//                            if(sumTmp <= 100000)
//                            {
//                                Console.WriteLine("add" + sumTmp);
//                                sum += sumTmp;
//                            }
//                            sumTmp = 0;
//                            break;
//                        }
//                        foreach(char c in lines[j])
//                        {
//                            if (Char.IsNumber(c))
//                            {
//                                testTmpNumber += c;
//                            }
//                        }
//                        if (int.TryParse(testTmpNumber, out n))
//                        {
//                            sumTmp += n;
//                            //Console.WriteLine(sumTmp);
//                        }
//                        testTmpNumber = "";
//                    }
//                }
//            }
//            Console.WriteLine(sum);
//            Console.ReadLine();
//        }
//    }
//}
