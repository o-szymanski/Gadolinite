using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class LeapTest
    {
        [Fact]
        public void YearNotDivisibleByFourInCommonYear()
        {
            Assert.False(LeapExercise.IsLeapYear(2015));
        }

        [Fact]
        public void YearDivisibleBy2NotDivisibleBy4InCommonYear()
        {
            Assert.False(LeapExercise.IsLeapYear(1970));
        }

        [Fact]
        public void YearDivisibleBy4NotDivisibleBy100InLeapYear()
        {
            Assert.True(LeapExercise.IsLeapYear(1996));
        }

        [Fact]
        public void YearDivisibleBy4And5IsStillALeapYear()
        {
            Assert.True(LeapExercise.IsLeapYear(1960));
        }
        [Fact]
        public void YearDivisibleBy100NotDivisibleBy400InCommonYear()
        {
            Assert.False(LeapExercise.IsLeapYear(2100));
        }
        [Fact]
        public void YearDivisibleBy100ButNotBy3IsStillNotALeapYear()
        {
            Assert.False(LeapExercise.IsLeapYear(1900));
        }
        [Fact]
        public void YearDivisibleBy400IsLeapYear()
        {
            Assert.True(LeapExercise.IsLeapYear(2000));
        }
        [Fact]
        public void YearDivisibleBy400ButNotBy125IsStillALeapYear()
        {
            Assert.True(LeapExercise.IsLeapYear(2400));
        }
        [Fact]
        public void YearDivisibleBy200NotDivisibleBy400InCommonYear()
        {
            Assert.False(LeapExercise.IsLeapYear(1800));
        }
    }
}
