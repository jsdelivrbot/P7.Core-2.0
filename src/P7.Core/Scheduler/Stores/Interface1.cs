﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P7.Core.Scheduler.Stores
{
    public interface IQuoteOfTheDataStore
    {
        Task SetQuoteAsync(QuoteOfTheDay quote);
        Task<QuoteOfTheDay> GetQuoteAsync();
    }

    public class QuoteOfTheDataStore : IQuoteOfTheDataStore
    {
        private QuoteOfTheDay QuoteOfTheDay { get; set; }
        public async Task SetQuoteAsync(QuoteOfTheDay quote)
        {
            QuoteOfTheDay = quote;
        }

        public async Task<QuoteOfTheDay> GetQuoteAsync()
        {
            return QuoteOfTheDay;
        }
    }
}
