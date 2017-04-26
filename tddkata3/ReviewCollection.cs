using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace tddkata3
{
    public class ReviewCollection
    {
        private readonly List<Review> m_Reviews = new List<Review>(); 
        public void Add(Review review)
        {
            m_Reviews.Add(review);
        }

        public IEnumerable<string> GetMovieNames()
        {
            return m_Reviews.Select(r => r.MovieName);
        }

        public double GetAverageRating(string movieName)
        {
            var scores = m_Reviews.Where(r => r.MovieName == movieName);
            return scores.Average(x => x.m_Rating);
        }

        public int GetReviewCount(string movieName, int rating)
        {
            return m_Reviews.Count(r => r.MovieName == movieName && r.m_Rating == rating);
        }
    }
}