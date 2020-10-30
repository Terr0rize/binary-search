using System;

namespace ConsoleApp10
{
    class Program
    {      

        static void Main(string[] args)
        {
            int[,] mat =    {{0,1,1,0,0,0,0,0,0,0,0},
                             {1,0,0,0,0,0,0,0,0,0,0},
                             {1,0,0,1,1,0,0,0,0,0,0},
                             {0,0,1,0,0,0,1,0,0,1,0},
                             {0,0,1,0,0,0,0,0,1,0,1},
                             {0,0,0,0,0,0,0,0,1,0,0},
                             {0,0,0,1,0,0,0,1,0,0,0},
                             {0,0,0,0,0,0,1,0,0,0,0},
                             {0,0,0,0,1,1,0,0,0,0,0},
                             {0,0,0,1,0,0,0,0,0,0,0},
                             {0,0,0,0,1,0,0,0,0,0,0}};

            int[,] mat_p =  {{0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0},

                             {0,0,0,0,0,0,0,0,0,0,0}};

            void puth(int[,] m, int[,] mp)
            {
                for (int k = 0; k < Math.Sqrt(m.Length); ++k)
                {
                    for (int i = 0; i < Math.Sqrt(m.Length); ++i)
                    {
                        for (int j = 0; j < Math.Sqrt(m.Length); ++j)
                        {
                            if (m[i, j] > m[i, k] + m[k, j])
                            {
                                m[i, j] = m[i, k] + m[k, j];
                                mp[i, j] = k;
                            }
                        }
                    }
                }
            }

             void red_path(int a, int b, int[,] m)
            {
                red_path_impl(a, b, m);
                Console.Write($"-> {b}");
            }

             void red_path_impl(int a, int b, int[,] m)
            {
                if (a == b || mat[a, b] == 1)
                {
                    Console.Write($"-> {a}");
                    return;
                }

                int k = m[a, b];
                red_path_impl(a, k, m);
                red_path_impl(k, b, m);
            }
             void print_mt(int[,] _m)
            {
                double t = Math.Sqrt(_m.Length);
                for (int i = 0; i < Math.Sqrt(_m.Length); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < Math.Sqrt(_m.Length); j++)
                        Console.Write(" " + _m[i, j]);
                }
                Console.WriteLine("\n**********************************");
            }
            
            for (int i = 0; i < Math.Sqrt(mat_p.Length); i++)
                for (int j = 0; j < Math.Sqrt(mat_p.Length); j++)
                {
                    if (mat[i, j] == 0)
                        mat[i, j] = 10000;
                    if (i == j) mat[i, j] = 0;
                }

            for (int i = 0; i < Math.Sqrt(mat_p.Length); i++)
                for (int j = 0; j < Math.Sqrt(mat_p.Length); j++)
                {
                    if (mat[i, j] == 10000)
                        mat_p[i, j] = 10000;
                    else
                    {
                        mat_p[i, j] = j;
                        if (i == j) mat_p[i, j] = 0;
                    }
                }
            puth(mat, mat_p);
            print_mt(mat);
            print_mt(mat_p);
            int a = 5;
            int b = 7;

            red_path(a, b, mat_p);

        }
    }
}
