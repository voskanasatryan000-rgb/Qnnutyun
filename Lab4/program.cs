using System;
class Program 
{ 
static void A(in int x) 
  { Console.WriteLine(x); 
  }
static void B(out int x)
  {
    x = 33;
    Console.WriteLine(x);
  }
static void C(ref int x)
{
    x *= 5;
    Console.WriteLine(x);
}

static int Gumar(params int[] x)
{
    int sum = 0;
    for(int i=0; i<x.Length;i++)
        sum += x[i];
    return sum;
}
static void Main()
{
    int a = 5;
    A(in a);

    int b;
    B(out b);

    int c = 10;
    C(ref c);

    int y = Gumar(5, 7, 3, 4, 5);
    Console.WriteLine(y);
  }
}
