using System;
using System.IO;

namespace practica1
{
    class Program
    {
        static long summ(int d,int m, int y)
        {
            //if (m > 2) m -= 3;
            //else
            //{
            //    m += 9;
            //    y--;
            //}
            //return 146097 * (y / 100) / 4 + 1461 * (y % 100) / 4 + (153 * m + 2) / 5 + d ;
            int a = (14 - m) / 12;
            y = y + 4800 - a;
            m = m + 12 * a - 3;
            return 365 * y + d + (153 * m + 2) / 5 + y / 4-y/100+y/400;//-32083
        }
        static void Main(string[] args)
        {
            //StreamReader sr = new StreamReader("INPUT.TXT");
            //string[] input1 = sr.ReadLine().Split('.');
            //string[] input2 = sr.ReadLine().Split('.');
            //sr.Close();

            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            string[] input1 = str.Split('.');
            string[] input2 = str2.Split('.');


            int[] time1 = new int[3];
            int[] time2 = new int[3];
            for (int i = 0; i < 3; i++)
                time1[i] = int.Parse(input1[i]);
            for (int i = 0; i < 3; i++)
                time2[i] = int.Parse(input2[i]);

            Console.WriteLine(summ(time2[0], time2[1], time2[2]) - summ(time1[0], time1[1], time1[2])+1);
            //StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            //sw.WriteLine(summ(time2[0], time2[1], time2[2]) - summ(time1[0], time1[1], time1[2]) + 1);
            //sw.Close();
        }
    }
}
