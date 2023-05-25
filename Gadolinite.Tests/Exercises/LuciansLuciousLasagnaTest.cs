using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class LuciansLuciousLasagnaTest
    {
        // Define the expected oven time in minutes

        [Fact]
        public void ExpectedMinutesInOven()
        {
            Assert.Equal((int)Minutes.Fourty, LuciansLuciousLasagnaExercise.ExpectedMinutesInOven());
        }

        // Calculate the remaining oven time in minutes

        [Fact]
        public void RemainingMinutesInOvenAfterTwentyFiveMinutes()
        {
            Assert.Equal((int)Minutes.Fifteen, LuciansLuciousLasagnaExercise.RemainingMinutesInOven((int)Minutes.TwentyFive));
        }

        [Fact]
        public void RemainingMinutesInOvenAfterThirtyThreeMinutes()
        {
            Assert.Equal((int)Minutes.Seven, LuciansLuciousLasagnaExercise.RemainingMinutesInOven((int)Minutes.ThirtyThree));
        }

        // Calculate the preparation time in minutes

        [Fact]
        public void PreparationTimeInMinutesForOneLayer()
        {
            Assert.Equal((int)Minutes.Two, LuciansLuciousLasagnaExercise.PreparationTimeInMinutes((int)Minutes.One));
        }

        [Fact]
        public void PreparationTimeInMinutesForMultipleLayer()
        {
            Assert.Equal((int)Minutes.Eight, LuciansLuciousLasagnaExercise.PreparationTimeInMinutes((int)Minutes.Four));
        }

        // Calculate the elapsed time in minutes

        [Fact]
        public void ElapsedTimeInMinutesforOneLayer()
        {
            Assert.Equal((int)Minutes.ThirtyTwo, LuciansLuciousLasagnaExercise.ElapsedTimeInMinutes((int)Minutes.One, (int)Minutes.Thirty));
        }

        [Fact]
        public void ElapsedTimeInMinutesforMultipleLayer()
        {
            Assert.Equal((int)Minutes.Sixteen, LuciansLuciousLasagnaExercise.ElapsedTimeInMinutes((int)Minutes.Four, (int)Minutes.Eight));
        }
    }
}
