using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class HelloWorldTest
    {
        [Fact]
        public void ValuesShouldBeEqual()
        {
            Assert.Equal("Hello, World!", HelloWorldExercise.SayHelloWorld());
        }
    }
}