namespace Gadolinite.Exercises.Exercises
{
     /* 
     Lucian's girlfriend is on her way home and he hasn't cooked their anniversary dinner! 
     In this exercise, you're going to write some code to help Lucian cook an exquisite lasagna from his favorite cook book. 
     You have four tasks, all related to the time spent cooking the lasagna.
     */

    public enum Minutes
    {
        One = 1,
        Two = 2,
        Four = 4,
        Seven = 7,
        Eight = 8,
        Fifteen = 15,
        Sixteen = 16,
        TwentyFive = 25,
        Thirty = 30,
        ThirtyTwo = 32,
        ThirtyThree = 33,
        Fourty = 40
    }

    public static class LuciansLuciousLasagnaExercise
    {
        public static int ExpectedMinutesInOven() => (int)Minutes.Fourty;

        public static int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * (int)Minutes.Two;

        public static int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;     

        public static int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven) => PreparationTimeInMinutes(numberOfLayers) + minutesInOven;

    }
}
