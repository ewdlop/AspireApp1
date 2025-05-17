using System;
using System.Collections.Generic;

namespace AspireApp1.Web.Services
{
    public class RandomService
    {
        private readonly Random _random = new();

        public int GenerateRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public string GenerateRandomQuote()
        {
            var quotes = new List<string>
            {
                "The only limit to our realization of tomorrow is our doubts of today.",
                "In the middle of every difficulty lies opportunity.",
                "Life is 10% what happens to us and 90% how we react to it.",
                "The best way to predict the future is to create it.",
                "Success is not final, failure is not fatal: It is the courage to continue that counts."
            };

            return quotes[_random.Next(quotes.Count)];
        }
    }
}