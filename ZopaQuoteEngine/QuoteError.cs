﻿namespace ZopaQuoteEngine
{
    enum QuoteError
    {
        NoQuotesAvailable,
        InsufficientMarketAvailable,
    }

    sealed class QuoteErrorParser
    {
        internal static string ExplainQuoteError(QuoteError error)
        {
            switch (error)
            {
                case QuoteError.NoQuotesAvailable:
                    return "No quotes were available to provide an offer.";
                case QuoteError.InsufficientMarketAvailable:
                    return "There are insufficient loan providers in the market to provide a quotation at this time.";
            }
            return "An unknown error was encountered attempting to provide a quote.";
        }
    }
}
