using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class DifferenceOfSquaresTest
    {
        [Fact]
        public void SquareOf_sum_1()
        {
            Assert.Equal(1, DifferenceOfSquaresExercise.CalculateSquareOfSum(1));
        }

        [Fact]
        public void SquareOfSum5()
        {
            Assert.Equal(225, DifferenceOfSquaresExercise.CalculateSquareOfSum(5));
        }

        [Fact]
        public void SquareOfSum100()
        {
            Assert.Equal(25502500, DifferenceOfSquaresExercise.CalculateSquareOfSum(100));
        }

        [Fact]
        public void SumOfSquares1()
        {
            Assert.Equal(1, DifferenceOfSquaresExercise.CalculateSumOfSquares(1));
        }

        [Fact]
        public void SumOfSquares5()
        {
            Assert.Equal(55, DifferenceOfSquaresExercise.CalculateSumOfSquares(5));
        }

        [Fact]
        public void SumOfSquares100()
        {
            Assert.Equal(338350, DifferenceOfSquaresExercise.CalculateSumOfSquares(100));
        }

        [Fact]
        public void DifferenceOfSquares1()
        {
            Assert.Equal(0, DifferenceOfSquaresExercise.CalculateDifferenceOfSquares(1));
        }

        [Fact]
        public void DifferenceOfSquares5()
        {
            Assert.Equal(170, DifferenceOfSquaresExercise.CalculateDifferenceOfSquares(5));
        }

        [Fact]
        public void DifferenceOfSquares100()
        {
            Assert.Equal(25164150, DifferenceOfSquaresExercise.CalculateDifferenceOfSquares(100));
        }
    }
}
