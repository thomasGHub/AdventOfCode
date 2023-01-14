using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Class10
    {
        static int cycle = 0;
        static int X = 1;
        static int result;
        static int mult = 0;
        static bool first = true;
        static string tmpLine;
        static int drawPos = 0;
        static void Main()
        {
            string textfile = @"textfile10.txt";
            string[] lines = File.ReadAllLines(textfile);

            foreach (string line in lines)
            {
                if (line == "noop")
                {
                    Nood();
                    Draw();
                }
                else if (line != "noop")
                {
                    tmpLine = line.Substring(5);

                    AddX();
                    Draw();
                    AddX();
                    Draw();

                    X += int.Parse(tmpLine);
                    //Console.WriteLine(int.Parse(tmpLine));
                }
            }

            //Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Nood()
        {
            cycle++;
            if (cycle == 20 && first)
            {
                mult += 20;
                result += X * mult;
                first = false;
                //Console.WriteLine("Cycle:{0}, mult:{1}", cycle, mult);
            }
            else if (((cycle + 20) % 40) == 0 && !first)
            {
                mult += 40;
                result += X * mult;
                //Console.WriteLine("Cycle:{0}, mult:{1}", cycle, mult);
            }
        }

        static void AddX()
        {
            cycle++;
            if (cycle == 20 && first)
            {
                mult += 20;
                result += X * mult;
                first = false;
                //Console.WriteLine("Cycle:{0}, mult:{1}, X:{2}", cycle, mult, X);
            }
            else if (((cycle + 20) % 40) == 0 && !first)
            {
              
                mult += 40;
                result += X * mult;
                //Console.WriteLine("Cycle:{0}, mult:{1}, X:{2}", cycle, mult, X);
            }
        }

        static void Draw()
        {
            if (drawPos % 40 == 0 && drawPos != 0)
            {
                Console.WriteLine();
            }
            if (Math.Abs(X - (drawPos % 40)) <= 1)
            {
                Console.Write('#');
            }
            else
            {
                Console.Write(' ');
            }
            ++drawPos;
        }
    }
}
