using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace tddkata3
{
    public class ReviewCollection
    {
        private readonly List<Review> m_Reviews = new List<Review>(); 
        public void Add(Review review)
        {
            if (review.Rating > 5 || review.Rating < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(review));
            }
            m_Reviews.Add(review);
        }

        public IEnumerable<string> GetMovieNames()
        {
            return m_Reviews.Select(r => r.MovieName);
        }

        public double GetAverageRating(string movieName)
        {
            var scores = m_Reviews.Where(r => r.MovieName == movieName);
            return scores.Average(x => x.Rating);
        }

        public int GetReviewCount(string movieName, int rating)
        {
            return m_Reviews.Count(r => r.MovieName == movieName && r.Rating == rating);
        }

        public IEnumerable<Review> GetReviews(string movieName)
        {
            return m_Reviews.Where(r => r.MovieName == movieName);
        }

        public string PrintNumberOfReviews(string movieName)
        {
            var stringBuilder = new StringBuilder();

            for (var i = 5; i > 0; i--)
            {
                stringBuilder.AppendLine(i + " " + GetReviewCount(movieName, i));
            }

            return stringBuilder.ToString();
        }
    }
}