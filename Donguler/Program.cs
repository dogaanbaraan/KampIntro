using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[] {"Avengers","Thor","Iron-Man" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(movies[i]);
               
            }

            Console.WriteLine("-----");

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
