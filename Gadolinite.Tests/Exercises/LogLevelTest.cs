using System.ComponentModel;
using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class LogLevelTest
    {
        // Get message from a log line

        [Fact]
        public void ErrorMessage()
        {
            Assert.Equal("Stack overflow", LogLevelsExercise.Message("[ERROR]: Stack overflow"));
        }

        [Fact]
        public void WarningMessage()
        {
            Assert.Equal("Disk almost full", LogLevelsExercise.Message("[WARNING]: Disk almost full"));
        }

        [Fact]
        public void InfoMessage()
        {
            Assert.Equal("File moved", LogLevelsExercise.Message("[INFO]: File moved"));
        }

        [Fact]
        public void MessageWithLeadingAndTrailingWhiteSpace()
        {
            Assert.Equal("Timezone not set", LogLevelsExercise.Message("[WARNING]:   \tTimezone not set  \r\n"));
        }

        // Get log level from a log line

        [Fact]
        public void ErrorLogLevel()
        {
            Assert.Equal("error", LogLevelsExercise.LogLevel("[ERROR]: Disk full"));
        }

        [Fact]
        public void WarningLogLevel()
        {
            Assert.Equal("warning", LogLevelsExercise.LogLevel("[WARNING]: Unsafe password"));
        }

        [Fact]
        public void InfoLogLevel()
        {
            Assert.Equal("info", LogLevelsExercise.LogLevel("[INFO]: Timezone changed"));
        }

        // Reformat a log line

        [Fact]
        public void ErrorReformat()
        {
            Assert.Equal("Segmentation fault (error)", LogLevelsExercise.Reformat("[ERROR]: Segmentation fault"));
        }

        [Fact]
        public void WarningReformat()
        {
            Assert.Equal("Decreased performance (warning)", LogLevelsExercise.Reformat("[WARNING]: Decreased performance"));
        }

        [Fact]
        public void InfoReformat()
        {
            Assert.Equal("Disk defragmented (info)", LogLevelsExercise.Reformat("[INFO]: Disk defragmented"));
        }

        [Fact]
        public void ReformatWithLeadingAndTrailingWhiteSpace()
        {
            Assert.Equal("Corrupt disk (error)", LogLevelsExercise.Reformat("[ERROR]: \t Corrupt disk\t \t \r\n"));
        }
    }
}
