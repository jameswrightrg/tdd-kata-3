using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using tddkata3;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Can_Leave_Review()
        {
            var reviewCollection = new ReviewCollection();
            var review = new Review("The Abyss", 4, "James Wright", "Pretty good");
            Assert.DoesNotThrow(() =>
            {
                reviewCollection.Add(review);
            });
        }

        [Test]
        public void Can_Print_Names_Of_Reviewed_Movies()
        {
            var reviewCollection = new ReviewCollection();
            var review = new Review("The Abyss", 4, "James Wright", "Pretty good");

            Assert.That(review.GetMovieNames(), Is.EquivalentTo(new[] {"The Abyss"}));
        }
    }
}
