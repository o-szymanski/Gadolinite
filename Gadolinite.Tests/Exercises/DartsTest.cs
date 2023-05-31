using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class DartsTest
    {
        [Fact]
        public void MissedTarget()
        {
            Assert.Equal(0, DartsExercise.Score(-9, 9));
        }

        [Fact]
        public void OnTheOuterCircle()
        {
            Assert.Equal(1, DartsExercise.Score(0, 10));
        }

        [Fact]
        public void OnTheMiddleCircle()
        {
            Assert.Equal(5, DartsExercise.Score(-5, 0));
        }

        [Fact]
        public void OnTheInnerCircle()
        {
            Assert.Equal(10, DartsExercise.Score(0, -1));
        }

        [Fact]
        public void ExactlyOnCentre()
        {
            Assert.Equal(10, DartsExercise.Score(0, 0));
        }

        [Fact]
        public void NearTheCentre()
        {
            Assert.Equal(10, DartsExercise.Score(-0.1, -0.1));
        }

        [Fact]
        public void JustWithinTheInnerCircle()
        {
            Assert.Equal(10, DartsExercise.Score(0.7, 0.7));
        }

        [Fact]
        public void JustOutsideTheInnerCircle()
        {
            Assert.Equal(5, DartsExercise.Score(0.8, -0.8));
        }

        [Fact]
        public void JustWithintheMiddleCircle()
        {
            Assert.Equal(5, DartsExercise.Score(-3.5, 3.5));
        }

        [Fact]
        public void JustOutsideTheMiddleCircle()
        {
            Assert.Equal(1, DartsExercise.Score(-3.6, -3.6));
        }

        [Fact]
        public void JustWithinTheOuterCircle()
        {
            Assert.Equal(1, DartsExercise.Score(-7, 7));
        }

        [Fact]
        public void JustOutsideTheOuterCircle()
        {
            Assert.Equal(0, DartsExercise.Score(7.1, -7.1));
        }

        [Fact]
        public void AsymmetricPositionBetweenTheInnerAndMiddleCircles()
        {
            Assert.Equal(5, DartsExercise.Score(0.5, -4));
        }
    }
}
