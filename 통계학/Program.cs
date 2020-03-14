using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
namespace 통계학
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = Convert.ToInt32(ReadLine());
            int[] numbers = WriteNumber(pass);
            AverageNumbers(numbers, pass);
            MiddleStatus(numbers, pass);
            MustShows(numbers);
            MaxMin(numbers);
        }
        static void MaxMin(int [] vs)
        {
            int max = 0;
            int min = vs[0];
            for (int i = 0; i < vs.Length; i++)
            {
                if (max < vs[i])
                    max = vs[i];

                if (min > vs[i])
                    min = vs[i];
            }
                int result = max - min;
                WriteLine("max : " + max + "," + "min : " + min);
                WriteLine("max - min =  " + result);
        }
        static void MustShows(int[] vs)
        {
            int[] shows = new int[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                for (int j = 0; j < vs.Length; j++)
                {
                    if (vs[i] == vs[j])
                        shows[i] += 1;
                }
                vs = vs.Distinct().ToArray();
                WriteLine($"최빈값({vs[i]})   :  {shows[i]}");
            }
        }
        static void MiddleStatus(int[] vs, int a)
        {
            int temp;
            Array.Sort(vs);
            int midstat = vs.Length / 2;
            WriteLine($"중앙값: {vs[midstat]}");
        }
        static void AverageNumbers(int[] vs, int a)
        {
            int sum = 0;
            foreach (int elem in vs)
            {
                sum += elem;
            }
            double result = sum / a;
            WriteLine($"산술평균:{Math.Round(result, 1)}");
        }
        static int[] WriteNumber(int a)
        {
            int[] numbers = new int[a];
            for (int i = 0; i < a; i++)
            {
                numbers[i] = Convert.ToInt32(ReadLine());
            }
            return numbers;
        }
    }
}
