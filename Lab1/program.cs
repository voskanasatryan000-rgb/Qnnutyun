using System;

namespace Matric
{
    class RandomMatric
    {
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }

        private int[,] matric;
        private Random r = new Random();

        public RandomMatric(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matric = new int[N, N];
            Arjeq();
        }

        private void Arjeq()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matric[i, j] = r.Next(A, B + 1);
                }
            }
        }

        public void Tvyal()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matric[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public int Kent()
        {
            int c = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matric[i, j] % 2 != 0)
                        c++;
                }
            }
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RandomMatric m = new RandomMatric(5, -10, 20);

            Console.WriteLine("Matric");
            m.Tvyal();

            Console.WriteLine($"Kenteri qanak {m.Kent()}");
        }
    }
}
