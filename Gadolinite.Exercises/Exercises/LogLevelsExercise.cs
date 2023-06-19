namespace Gadolinite.Exercises.Exercises
{
    /*    
    In this exercise you'll be processing log-lines. Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>". There are three different log levels: INFO WARNING ERROR
    You have three tasks, each of which will take a log line and ask you to do something with it.
    */
    public static class LogLevelsExercise
    {
        public static string Message(string logLine) => logLine[(logLine.IndexOf(':') + 1)..].Trim();
        public static string LogLevel(string logLine) => logLine[1..logLine.IndexOf(']')].ToLower();
        public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
