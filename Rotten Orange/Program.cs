using System;

namespace Rotten_Orange
{
    class Program
    {
        
        static int[,] A = new int[,]
        { {2, 1, 0, 2, 1},
                     {1, 0, 1, 2, 1},
                     {1, 0, 0, 2, 1}
        };
        static int m = A.GetLength(0), n = A.GetLength(1);

        static int[] X = new int[] { -1, 1, 0, 0 };
        static int[] Y = new int[] { 0, 0, -1, 1 };
        static int timeFrame = 0;
        static bool[,] visited = new bool[m, n];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    visited[i, j] = false;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (visited[i, j] == true) continue;
                    if (A[i, j] == 2)
                    {
                        visited[i, j] = true;
                        timeFrame += 1;
                        DFS(i, j);
                    }
                    visited[i, j] = true;
                }

            }
            Console.WriteLine($"Time Frame {timeFrame}");
            Console.ReadKey();
        }
        static void DFS(int i, int j)
        {
            if (!isValid(i, j)) return;
            int nexti = 0, nextj = 0;


            for (int k = 0; k < 4; k++)
            {
                nexti = i + X[k];
                nextj = j + Y[k];

                if (!isValid(nexti, nextj) || visited[nexti, nextj]) continue;
                visited[nexti, nextj] = true;
                DFS(nexti, nextj);

            }
        }


        static bool isValid(int i, int j)
        {
            return (!(i < 0 || j < 0 || i > (m - 1) || j > (n - 1) || A[i, j] == 0));
        }
    }
}
