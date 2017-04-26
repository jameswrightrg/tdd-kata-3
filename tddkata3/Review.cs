using System.Collections;
using System.Collections.Generic;

namespace tddkata3
{
    public class Review
    {
        public readonly string MovieName;
        public readonly int m_Rating;

        public Review(string movieName, int rating, string reviewer, string description)
        {
            MovieName = movieName;
            m_Rating = rating;
        }
    }
}