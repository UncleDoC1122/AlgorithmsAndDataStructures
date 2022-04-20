using System;
using System.Diagnostics;

namespace AlgorithmsAndDataStructuresCourse.Tests
{
    public static class StopwatchDecorator
    {
        public static long StopwatchTest(Action test)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            test();

            return stopwatch.ElapsedTicks;
        }
    }
}
