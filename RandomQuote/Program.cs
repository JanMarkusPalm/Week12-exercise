using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("49 Wise Quotes That Will Inspire You To Success In Life");
            Console.WriteLine(GetRandomJoke());

        }
        public static string GetRandomJoke()
        {
            string filepath = @"C:\Users\opilane\samples\49WiseQuotes.txt";
            string[] jokeAboutChuck = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, jokeAboutChuck.Length);

            return jokeAboutChuck[RandomIndex];
        }
    }
}
