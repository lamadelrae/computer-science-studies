namespace ComputerScienceStudies.Queue
{
    public class QueueExample
    {
        [Fact]
        public void HowAQueueWorks()
        {
            Queue<string> queueOfStrings = new Queue<string>();
            queueOfStrings.Enqueue("First");
            queueOfStrings.Enqueue("Second");
            queueOfStrings.Enqueue("Third");
            queueOfStrings.Enqueue("Fourth");

            Assert.Equal("First", queueOfStrings.Dequeue());
            Assert.Equal("Second", queueOfStrings.Dequeue());
            Assert.Equal("Third", queueOfStrings.Dequeue());
            Assert.Equal("Fourth", queueOfStrings.Dequeue());
        }
    }
}
