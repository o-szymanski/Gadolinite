namespace Gadolinite.Exercises.Exercises
{
    /* 
    Continuing the theme of the wizards and warriors game, it is time to add an all purpose die rolling method. This will be the traditional 18 sided die with numbers 1 to 18. Players also generate a spell strength.
    */

    public static class RollTheDieExercise
    {
        private static readonly Random Random = new();
        private static readonly int MaxDieNumber = 18;
        private static readonly double MaxStrength = 100.0;

        public static int RollDie() => Random.Next(1, MaxDieNumber + 1);

        public static double GenerateSpellStrength() => Random.NextDouble() * MaxStrength;
    }
}
