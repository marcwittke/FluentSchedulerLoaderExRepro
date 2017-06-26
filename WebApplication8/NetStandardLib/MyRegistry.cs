using System;

namespace NetStandardLib
{
    using FluentScheduler;

    public class HelloJob : IJob
    {
        public void Execute()
        {
            Console.WriteLine("Hello");
        }
    }

    public class MyRegistry : Registry
    {
        public MyRegistry()
        {
            Schedule<HelloJob>().ToRunNow().AndEvery(10).Seconds();
        }
    }
}
