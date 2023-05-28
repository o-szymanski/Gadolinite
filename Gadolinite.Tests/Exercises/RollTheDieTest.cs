using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class RollTheDieTest
    {
        // Enable a wizards and warriors player to roll a die.


        [Fact]
        public void RollDie()
        {
            for (var i = 0; i < 100; i++)
            {
                var value = RollTheDieExercise.RollDie();
                Assert.InRange(value, 1, 18);
            }
        }

        // Players need their strength. Provide a means to generate spell strength

        [Fact]
        public void GenerateSpellStrength()
        {
            for (var i = 0; i < 100; i++)
            {
                var strength = RollTheDieExercise.GenerateSpellStrength();
                Assert.InRange(strength, 0.0, 100.0);
            }
        }
    }
}
