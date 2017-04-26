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
    }
}