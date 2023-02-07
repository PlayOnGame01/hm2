using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы_в.NET_homework_02._02._2023
{
    internal class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = 0;
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            #region ex1
            //int[] mas = new int[10];
            //Random rand = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rand.Next(1, 101);
            //    Console.Write($"{mas[i]}  ");
            //}
            //Console.WriteLine("\n");
            //int[] mas_nechet = new int[10];
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] % 2 != 0)
            //    {
            //        mas_nechet[i] = mas[i];
            //    }
            //    Console.Write($"{mas_nechet[i]}  ");
            //}
            //int max_nechet = 0, pos = 0;
            //for (int i = 0; i < mas_nechet.Length; i++)
            //{
            //    if (max_nechet < mas_nechet[i]) { max_nechet = mas_nechet[i]; pos = i; }
            //}
            //Console.WriteLine($"\nMax nechet = {max_nechet}\nPosition = {pos}\n");
            //int a = mas[pos];
            //for (int i = pos + 1; i < mas.Length; i++)
            //{
            //    Swap(ref mas[pos], ref mas[i]);
            //    pos++;
            //}
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    Console.Write($"{mas[i]}  ");
            //}
            #endregion

            #region ex2
            //int[] mas = new int[10];
            //Random rand = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rand.Next(0, 5);
            //    Console.Write($"{mas[i]}  ");
            //}
            //Console.WriteLine("\n");
            //int sum = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] == 0)
            //    {
            //        i++;
            //        while (mas[i] != 0) { sum += mas[i]; i++; }
            //    }
            //}
            //Console.WriteLine($"Sum = {sum}");
            #endregion

            #region ex3
            int[] mas_A = new int[5];
            Console.Write("Enter num of mas: ");
            string n = Console.ReadLine();
            int sum_num = Convert.ToInt32(n);
            Console.WriteLine("Enter 5 from 10:");
            string str = null; int num = 0; int sum = 0;
            while (sum_num != sum)
            {
                for (int i = 0; i < mas_A.Length; i++)
                {
                    str = Console.ReadLine();
                    num = Convert.ToInt32(str);
                    mas_A[i] = num;
                    sum += mas_A[i];
                }
                Console.WriteLine();
                if (sum_num != sum)
                {
                    Console.WriteLine("Sum number != mas elements!\nTry again!\nEnter 5 from 10:");
                    sum = 0;
                }
            }
            Console.WriteLine("PERFFECT!\n");
            for (int i = 0; i < mas_A.Length; i++)
            {
                Console.Write($"{mas_A[i]}  ");
            }
            Console.WriteLine();
            int[] mas_B = new int[3];
            Random rand = new Random();
            int a = 0;
            for (int i = 0; i < mas_B.Length; i++)
            {
                mas_B[i] = rand.Next(1, 10);
                Console.Write($"{mas_B[i]}  ");
            }
            for (int i = 0; i < mas_B.Length; i++)
            {
                for (int j = 0; j < mas_A.Length; j++)
                {
                    if (mas_B[i] == mas_A[j]) { a++; break; }
                }
            }
            Console.WriteLine($"a = {a}");
            if (a == 3)
            {
                Console.WriteLine("mas_A subset as set mas_B");
            }
            else { Console.WriteLine("mas_A is not subset as set mas_B"); }
            #endregion

        }
    }
}