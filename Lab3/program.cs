using System;

namespace MovieDemo
{
    public enum Janr
    {
        Sarsap = 1,
        Humor = 2,
        Drama = 3,
        Romantik = 4,
        Kriv = 5
    }

    public class Movie
    {
        public int Id;
        public string Anun;
        public int Tari;
        public Janr Janr;
        public int Ditum;
        public int Liker;

        public Movie(string line)
        {
            string[] parts = line.Split(',');

            Id = int.Parse(parts[0].Trim());
            Anun = parts[1].Trim();
            Tari = int.Parse(parts[2].Trim());
            Janr = (Janr)int.Parse(parts[3].Trim());
            Ditum = int.Parse(parts[4].Trim());
            Liker = int.Parse(parts[5].Trim());
        }

        public double GetRating()
        {
            return Math.Sqrt(Math.Pow(Liker, 2) / Ditum);
        }

        public override string ToString()
        {
            string tari = "(" + Tari + ")";
            return string.Format("{0,4} {1,-15} {2,-8} {3,-12} {4,8:F3}",
                                 Id, Anun, tari, Janr, GetRating());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Filmeri qanak: ");
            int count = int.Parse(Console.ReadLine());

            Movie[] movies = new Movie[count];

            Console.WriteLine("DZEVACHAP hamar, anun, taretiv, janr (1-5), ditum, like");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"film #{i + 1}: ");
                movies[i] = new Movie(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
