namespace Gadolinite.Exercises.Exercises
{
    /*
    In this exercise you'll be working with savings accounts. Each year, the balance of your savings account is updated based on its interest rate. The interest rate your bank gives you depends on the amount of money in your account (its balance):
    3.213% for a negative balance (balance gets more negative).
    0.5% for a positive balance less than 1000 dollars.
    1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
    2.475% for a positive balance greater than or equal to 5000 dollars.
    You have four tasks, each of which will deal your balance and its interest rate.
    */

    public static class InterestIsInterestingExercise
    {
        public static float InterestRate(decimal balance) => balance switch
        {
            < 0 => 3.213f,
            < 1000 => 0.5f,
            >= 1000 and < 5000 => 1.621f,
            >= 5000 => 2.475f
        };

        public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) / 100 * balance;

        public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int years = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                years++;
            }
            return years;
        }
    }
}
