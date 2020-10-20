using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication64
{
    class Program
    {
        static long Power(long x, int n)
        {
            var result = 1L;
            while (n > 0)
            {
                if ((n & 1) == 0)
                {
                    x *= x;
                    n >>= 1;                   
                }
                else
                {
                    result *= x;
                    --n;
                }
            }

            return result;
        }


        public static int Gorner(int[] a, int n, int x)
        {
            int h = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                h = h * x;
                h = h + a[i];

            }
            return (h);
        }

        static void Main()
        {                                      
            Console.WriteLine("Исходные значения для возведения в степень: 5 и 3. 5 возводится в 3 степень. ");
            Console.WriteLine("Ответ: " + Power(5, 3));           
            Console.ReadKey();
            Console.Clear();
            int result;
            string s;
            Console.WriteLine("Введите количество х");
            s = Console.ReadLine();
            int k = int.Parse(s);
            int[] ko;
            ko = new int[k + 1];

            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine("Введите коэффициент при x^ {0}", i);
                s = Console.ReadLine();
                ko[i] = int.Parse(s);
            }
            Console.WriteLine("Введите x");
            s = Console.ReadLine();
            int x = int.Parse(s);

            s = "";

            for (int i = k; i >= 0; i = i - 1)
            {
                s = s + ko[i].ToString() + "*x^" + i.ToString() + "+";

            }
            s += "0=";
            result = Gorner(ko, k + 1, x);

            Console.WriteLine(s + result.ToString());
            Console.ReadKey();

        }    
    }
} 
