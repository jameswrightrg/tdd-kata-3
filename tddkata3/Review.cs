using System;
using System.Collections;
using System.Collections.Generic;

namespace tddkata3
{
    public class Review
    {
        public readonly string MovieName;
        public readonly int Rating;
        public readonly string Reviewer;

        public Review(string movieName, int rating, string reviewer, string description)
        {
            MovieName = movieName;
            Rating = rating;

            Reviewer = reviewer == string.Empty ? "Anonymous" : reviewer;
        }
    }
}