
using System;

namespace lab2
{
    class Program
    {
        static int ToMultiplicate(int x, int N = 2)
        {
            Console.WriteLine("kancvhume int funkcian");
            return x*N;
        }

        static double ToMultiplicate(double x, int N = 2)
        {
          Console.WriteLine("kancvhume double funkcian");
            double sum = 0.0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        static string ToMultiplicate(string x, int N = 2)
        {
          Console.WriteLine("kancvhume string funkcian");
            string sum = "";
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToMultiplicate(8));        
            Console.WriteLine(ToMultiplicate(9, 4));     
            Console.WriteLine(ToMultiplicate(4.5));      
            Console.WriteLine(ToMultiplicate(2.5, 3));   
            Console.WriteLine(ToMultiplicate("abb"));     
            Console.WriteLine(ToMultiplicate("acb", 3));  
        }
    }
}
