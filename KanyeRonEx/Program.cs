using System;
using System.Net.Http;

namespace KanyeRonEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var kwote = new QuoteGetter(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye - {kwote.KanyeGetter()}");
                Console.WriteLine($"Ron - {kwote.RonGetter()}");
            }
        }
    }
}
