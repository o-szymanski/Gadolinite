using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class InterestIsInterestingTest
    {
        // Calculate the interest rate

        [Fact]
        public void MinimalFirstInterestRate()
        {
            Assert.Equal(0.5f, InterestIsInterestingExercise.InterestRate(0m));
        }

        [Fact]
        public void TinyFirstInterestRate()
        {
            Assert.Equal(0.5f, InterestIsInterestingExercise.InterestRate(0.000001m));
        }

        [Fact]
        public void MaximumFirstInterestRate()
        {
            Assert.Equal(0.5f, InterestIsInterestingExercise.InterestRate(999.9999m));
        }

        [Fact]
        public void MinimalSecondInterestRate()
        {
            Assert.Equal(1.621f, InterestIsInterestingExercise.InterestRate(1_000.0m));
        }

        [Fact]
        public void TinySecondInterestRate()
        {
            Assert.Equal(1.621f, InterestIsInterestingExercise.InterestRate(1_000.0001m));
        }

        [Fact]
        public void MaximumSecondInterestRate()
        {
            Assert.Equal(1.621f, InterestIsInterestingExercise.InterestRate(4_999.9990m));
        }

        [Fact]
        public void MinimalThirdInterestRate()
        {
            Assert.Equal(2.475f, InterestIsInterestingExercise.InterestRate(5_000.0000m));
        }

        [Fact]
        public void TinyThirdInterestRate()
        {
            Assert.Equal(2.475f, InterestIsInterestingExercise.InterestRate(5_000.0001m));
        }

        [Fact]
        public void LargeThirdInterestRate()
        {
            Assert.Equal(2.475f, InterestIsInterestingExercise.InterestRate(5_639_998.742909m));
        }

        [Fact]
        public void RateOnMinimalNegativeBalance()
        {
            Assert.Equal(3.213f, InterestIsInterestingExercise.InterestRate(-0.000001m));
        }

        [Fact]
        public void RateOnSmallNegativeBalance()
        {
            Assert.Equal(3.213f, InterestIsInterestingExercise.InterestRate(-0.123m));
        }

        [Fact]
        public void RateOnRegularNegativeBalance()
        {
            Assert.Equal(3.213f, InterestIsInterestingExercise.InterestRate(-300.0m));
        }

        [Fact]
        public void RateOnLargeNegativeBalance()
        {
            Assert.Equal(3.213f, InterestIsInterestingExercise.InterestRate(-152964.231m));
        }

        // Calculate the interest

        [Fact]
        public void InterestOnNegativeBalance()
        {
            Assert.Equal(-321.3m, InterestIsInterestingExercise.Interest(-10000.0m));
        }

        [Fact]
        public void InterestOnSmallBalance()
        {
            Assert.Equal(2.77775m, InterestIsInterestingExercise.Interest(555.55m));
        }

        [Fact]
        public void InterestOnMediumBalance()
        {
            Assert.Equal(81.0498379m, InterestIsInterestingExercise.Interest(4999.99m));
        }

        [Fact]
        public void InterestOnLargeBalance()
        {
            Assert.Equal(856.3698m, InterestIsInterestingExercise.Interest(34600.80m));
        }

        // Calculate the annual balance update

        [Fact]
        public void AnnualBalanceUpdateForEmptyStartBalance()
        {
            Assert.Equal(0.0000m, InterestIsInterestingExercise.AnnualBalanceUpdate(0.0m));
        }

        [Fact]
        public void AnnualBalanceUpdateForSmallPositiveStartBalance()
        {
            Assert.Equal(0.000001005m, InterestIsInterestingExercise.AnnualBalanceUpdate(0.000001m));
        }

        [Fact]
        public void AnnualBalanceUpdateForAveragePositiveStartBalance()
        {
            Assert.Equal(1016.210000m, InterestIsInterestingExercise.AnnualBalanceUpdate(1_000.0m));
        }

        [Fact]
        public void AnnualBalanceUpdateForLargePositiveStartBalance()
        {
            Assert.Equal(1016.210101621m, InterestIsInterestingExercise.AnnualBalanceUpdate(1_000.0001m));
        }

        [Fact]
        public void AnnualBalanceUpdateForHugePositiveStartBalance()
        {
            Assert.Equal(920352587.26744292868451875m, InterestIsInterestingExercise.AnnualBalanceUpdate(898124017.826243404425m));
        }

        [Fact]
        public void AnnualBalanceUpdateForSmallNegativeStartBalance()
        {
            Assert.Equal(-0.12695199m, InterestIsInterestingExercise.AnnualBalanceUpdate(-0.123m));
        }

        [Fact]
        public void AnnualBalanceUpdateForLargeNegativeStartBalance()
        {
            Assert.Equal(-157878.97174203m, InterestIsInterestingExercise.AnnualBalanceUpdate(-152964.231m));
        }

        // Calculate the years before reaching the desired balance

        [Fact]
        public void YearBeforeDeisredBalanceForSmallStartBalance()
        {
            Assert.Equal(47, InterestIsInterestingExercise.YearsBeforeDesiredBalance(100.0m, 125.80m));
        }

        [Fact]
        public void YearBeforeDeisredBalanceForAverageStartBalance()
        {
            Assert.Equal(6, InterestIsInterestingExercise.YearsBeforeDesiredBalance(1_000.0m, 1_100.0m));
        }

        [Fact]
        public void YearBeforeDeisredBalanceForLargeStartBalance()
        {
            Assert.Equal(5, InterestIsInterestingExercise.YearsBeforeDesiredBalance(8_080.80m, 9_090.90m));
        }

        [Fact]
        public void YearBeforeDeisredBalanceForLargeDifferentBetweenStartAndtargetBalance()
        {
            Assert.Equal(85, InterestIsInterestingExercise.YearsBeforeDesiredBalance(2_345.67m, 12_345.6789m));
        }
    }
}
