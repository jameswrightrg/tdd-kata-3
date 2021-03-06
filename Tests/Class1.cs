﻿using System;
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

            reviewCollection.Add(review);

            Assert.That(reviewCollection.GetMovieNames(), Is.EquivalentTo(new[] {"The Abyss"}));
        }

        [Test]
        public void Calculates_Average_Rating_For_Movie()
        {
            var reviewCollection = new ReviewCollection();
            var review1 = new Review("The Abyss", 4, "James Wright", "Pretty good");
            var review2 = new Review("The Abyss", 2, "James Wright", "Pretty poor");

            reviewCollection.Add(review1);
            reviewCollection.Add(review2);

            Assert.That(reviewCollection.GetAverageRating("The Abyss"), Is.EqualTo(3));
        }

        [Test]
        public void Get_Number_Of_Reviews_For_Particular_Rating()
        {
            var reviewCollection = new ReviewCollection();

            var review1 = new Review("The Abyss", 4, "James Wright", "Pretty good");
            var review2 = new Review("The Abyss", 4, "James Wright", "Pretty poor");

            reviewCollection.Add(review1);
            reviewCollection.Add(review2);

            Assert.That(reviewCollection.GetReviewCount("The Abyss", 4), Is.EqualTo(2));
        }

        [Test]
        public void Name_Of_Reviewer_Defaults_To_Anonymous()
        {
            var reviewCollection = new ReviewCollection();

            var review = new Review("The Abyss", 4, string.Empty, "Pretty good");

            reviewCollection.Add(review);

            Assert.That(reviewCollection.GetReviews("The Abyss").First().Reviewer, Is.EqualTo("Anonymous"));
        }

        [Test]
        public void Review_Should_Be_Within_Set_Range()
        {
            var reviewCollection = new ReviewCollection();

            var review = new Review("The Abyss", 6, string.Empty, "Amazingly good");

            Assert.Throws<ArgumentOutOfRangeException>(() => reviewCollection.Add(review));
        }

        [Test]
        public void Prints_Number_Of_Reviews_For_Each_Rating()
        {
            var reviewCollection = new ReviewCollection();

            var review1 = new Review("The Abyss", 4, "James Wright", "Pretty good");
            var review2 = new Review("The Abyss", 2, "James Wright", "Pretty poor");

            reviewCollection.Add(review1);
            reviewCollection.Add(review2);

            Assert.That(reviewCollection.PrintNumberOfReviews("The Abyss"), Is.EqualTo(
                "5 0" + Environment.NewLine +
                "4 1" + Environment.NewLine +
                "3 0" + Environment.NewLine +
                "2 1" + Environment.NewLine +
                "1 0" + Environment.NewLine
                ));

        }
    }
}
