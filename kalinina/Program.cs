using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            long M2, M11, M22, R, MAX, dat, res, N;
            M2 = 0;
            M11 = 0;
            M22 = 0;
            MAX = 0;

            N = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                dat = Convert.ToInt64(Console.ReadLine());
                if ((dat % 2 == 0) && (dat % 11 > 0) && dat > M2)
                {
                    M2 = dat;
                }
                if (dat % 11 == 0 && dat % 2 > 0 && dat > M11)
                {
                    M11 = dat;
                }
                if (dat % 11 == 0 && dat > M22)
                {
                    if (M22 > MAX)
                    {
                        MAX = M22;
                        M22 = dat;
                    }
                }
                else
                {
                    if (dat > MAX)
                        MAX = dat;
                }

                R = Convert.ToInt64(Console.ReadLine());
                if (M2 * M11 < M22 * MAX)
                {
                    res = M22 * MAX;
                    Console.WriteLine($"Вычисленное контрольное значение {i}: {res}");

                    if (R == res)
                    {
                        Console.WriteLine("Контроль пройден");
                    }
                    else
                    {
                        Console.WriteLine("Контроль не пройден");
                    }

                }
                else
                {

                    res = M2 * M11;
                    Console.WriteLine($"Вычисленное контрольное значение {i}: {res}");

                    if (R == res)
                    {
                        Console.WriteLine("Контроль пройден");
                    }
                    else
                    {
                        Console.WriteLine("Контроль не пройден");
                    }
                }


            }
        }
    }
}