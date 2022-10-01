namespace ComputerScienceStudies.Stack
{
    public class StackExample
    {
        [Fact]
        public void HowAStackWorks()
        {
            Stack<string> stackOfStrings = new Stack<string>();
            stackOfStrings.Push("First");
            stackOfStrings.Push("Second");
            stackOfStrings.Push("Third");
            stackOfStrings.Push("Fourth");

            Assert.Equal("Fourth", stackOfStrings.Pop());
            Assert.Equal("Third", stackOfStrings.Pop());
            Assert.Equal("Second", stackOfStrings.Pop());
            Assert.Equal("First", stackOfStrings.Pop());
        }
    }
}
