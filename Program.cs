using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quest1
            Func<int, int, int, int> minNumber = (num1, num2, num3) => Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine(minNumber(20, 60, 100));

            //Quest2
            Func<int, int, int, int> averageNumber = (num1, num2, num3) => (num1 + num2 + num3) / 3;
            Console.WriteLine(averageNumber(20, 60, 100));

            //Quest3
            Func<string, string> middleChar = str =>
            {
                int position = str.Length / 2 - 1;
                string strIzugi = Convert.ToString(str[position]) + Convert.ToString(str[position + 1]);

                if (str.Length % 2 == 0)
                {
                    return Convert.ToString(str[position]);
                }
                return strIzugi;
            };
            Console.WriteLine(middleChar("Dennis"));//Zugi Output n
            Console.WriteLine(middleChar("Ronaldo"));//IZugi Output na

            //Quest4
            Func<string, int> vowelsCount = str =>
            {
                string lowerStr = str.ToLower();
                int count = 0;
                for (int i = 0; i < lowerStr.Length; i++)
                {
                    if (lowerStr[i] == 'a' || lowerStr[i] == 'e' || lowerStr[i] == 'i' || lowerStr[i] == 'o' || lowerStr[i] == 'u')
                    {
                        count++;
                    }
                }
                return count;
            };
            Console.WriteLine(vowelsCount("Dennis"));// Output 2

            //Quest5
            Func<string, int> wordsCount = str =>
            {
                List<string> listCount = str.Split(' ', ',').ToList();
                listCount.RemoveAll(strvalue => strvalue == "");
                return listCount.Count;
            };
            Console.WriteLine(wordsCount("My Name Is Dennis"));// Output 4

            //Quest6
            Func<long, int> digitCompute = num =>
            {
                long sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return Convert.ToInt32(sum);
            };
            Console.WriteLine(digitCompute(253));// Output 10
            Console.ReadLine();
        }
    }
    }

