namespace Gadolinite.Exercises.Exercises
{
    /* 
    In this exercise you'll be writing code to analyze the production of an assembly line in a car factory. The assembly line's speed can range from 0 (off) to 10 (maximum).
    At its lowest speed (1), 221 cars are produced each hour. The production increases linearly with the speed. So with the speed set to 4, it should produce 4 * 221 = 884 cars per hour. 
    However, higher speeds increase the likelihood that faulty cars are produced, which then have to be discarded. You have three tasks.
    The following table shows how speed influences the success rate: 0: 0% success rate. 1 to 4: 100% success rate. 5 to 8: 90% success rate. 9: 80% success rate. 10: 77% success rate.
    */

    public static class CarsAssembleExercise
    {
        private const int BaseCarProductionPerOneHour = 221;

        public static double SuccessRate(int speed) => speed switch
        {
            0 => 0.00,
            1 or 2 or 3 or 4 => 1.00,
            5 or 6 or 7 or 8 => 0.90,
            9 => 0.80,
            10 => 0.77,
            _ => 0
        };

        public static double ProductionRatePerHour(int speed) => speed * BaseCarProductionPerOneHour * SuccessRate(speed);

        public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
    }
}
