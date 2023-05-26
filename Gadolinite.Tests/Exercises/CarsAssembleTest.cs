using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class CarsAssembleTest
    {
        // Calculate the success rate

        [Fact]
        public void SuccessRateForSpeedZero()
        {
            Assert.Equal(0.0, CarsAssembleExercise.SuccessRate(0), precision: 1);
        }

        [Fact]
        public void SuccessRateForSpeedOne()
        {
            Assert.Equal(1.0, CarsAssembleExercise.SuccessRate(1), precision: 1);
        }

        [Fact]
        public void SuccessRateForSpeedFour()
        {
            Assert.Equal(1.0, CarsAssembleExercise.SuccessRate(4), precision: 1);
        }

        [Fact]
        public void SuccessRateForSpeedFive()
        {
            Assert.Equal(0.9, CarsAssembleExercise.SuccessRate(5), precision: 1);
        }

        [Fact]
        public void SuccessRateForSpeedNine()
        {
            Assert.Equal(0.8, CarsAssembleExercise.SuccessRate(9), precision: 1);
        }

        [Fact]
        public void SuccessRateForSpeedTen()
        {
            Assert.Equal(0.77, CarsAssembleExercise.SuccessRate(10), precision: 2);
        }

        // Calculate the production rate per hour

        [Fact]
        public void ProductionRatePerHourForSpeedZero()
        {
            Assert.Equal(0.0, CarsAssembleExercise.ProductionRatePerHour(0), precision: 1);
        }

        [Fact]
        public void ProductionRatePerHourForSpeedOne()
        {
            Assert.Equal(221.0, CarsAssembleExercise.ProductionRatePerHour(1), precision: 1);
        }

        [Fact]
        public void ProductionRatePerHourForSpeedFour()
        {
            Assert.Equal(884.0, CarsAssembleExercise.ProductionRatePerHour(4), precision: 1);
        }

        [Fact]
        public void ProductionRatePerHourForSpeedSeven()
        {
            Assert.Equal(1392.3, CarsAssembleExercise.ProductionRatePerHour(7), precision: 1);
        }

        [Fact]
        public void ProductionRatePerHourForSpeedNine()
        {
            Assert.Equal(1591.2, CarsAssembleExercise.ProductionRatePerHour(9), precision: 1);
        }

        [Fact]
        public void ProductionRatePerHourForSpeedTen()
        {
            Assert.Equal(1701.7, CarsAssembleExercise.ProductionRatePerHour(10), precision: 1);
        }

        // Calculate the number of working items produced per minute

        [Fact]
        public void WorkingItemsPerMinuteforSpeedZero()
        {
            Assert.Equal(0, CarsAssembleExercise.WorkingItemsPerMinute(0));
        }

        [Fact]
        public void WorkingItemsPerMinuteforSpeedOne()
        {
            Assert.Equal(3, CarsAssembleExercise.WorkingItemsPerMinute(1));
        }

        [Fact]
        public void WorkingItemsPerMinuteforSpeedFive()
        {
            Assert.Equal(16, CarsAssembleExercise.WorkingItemsPerMinute(5));
        }

        [Fact]
        public void WorkingItemsPerMinuteforSpeedEight()
        {
            Assert.Equal(26, CarsAssembleExercise.WorkingItemsPerMinute(8));
        }

        [Fact]
        public void WorkingItemsPerMinuteforSpeedNine()
        {
            Assert.Equal(26, CarsAssembleExercise.WorkingItemsPerMinute(9));
        }

        [Fact]
        public void WorkingItemsPerMinuteforSpeedTen()
        {
            Assert.Equal(28, CarsAssembleExercise.WorkingItemsPerMinute(10));
        }
    }
}
