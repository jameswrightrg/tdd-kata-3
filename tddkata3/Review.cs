using System.Collections;
using System.Collections.Generic;

namespace tddkata3
{
    public class Review
    {
        public readonly string MovieName;
        public Review(string movieName, int rating, string reviewer, string description)
        {
            MovieName = movieName;
        }
    }
}