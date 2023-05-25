namespace Gadolinite.Exercises.Exercises
{
     /* 
     Lucian's girlfriend is on her way home and he hasn't cooked their anniversary dinner! 
     In this exercise, you're going to write some code to help Lucian cook an exquisite lasagna from his favorite cook book. 
     You have four tasks, all related to the time spent cooking the lasagna.
     Define the method that does not take any parameters and returns how many minutes the lasagna should be in the oven. According to the cooking book, the expected oven time in minutes is 40 
     Define the method that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected oven time in minutes from the previous task.
     Define the method that takes the number of layers you added to the lasagna as a parameter and returns how many minutes you spent preparing the lasagna, assuming each layer takes you 2 minutes to prepare.
     Define the method that takes two parameters: the first parameter is the number of layers you added to the lasagna, and the second parameter is the number of minutes the lasagna has been in the oven. 
     The function should return how many minutes you've worked on cooking the lasagna, which is the sum of the preparation time in minutes, and the time in minutes the lasagna has spent in the oven at the moment. 
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
