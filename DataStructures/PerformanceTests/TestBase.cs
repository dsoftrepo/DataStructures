using System;
using System.Diagnostics;
using NUnit.Framework;

namespace DataStructures.PerformanceTests
{
    [TestFixture]
    public abstract class TestBase
    {
        private Stopwatch _stopWatch;

        [SetUp]
        public virtual void Init()
        {
            _stopWatch = Stopwatch.StartNew();
        }

        [TearDown]
        public void Cleanup()
        {
            _stopWatch.Stop();
            Console.WriteLine("Excution time for {0} - {1} ms", TestContext.CurrentContext.Test.Name,  _stopWatch.ElapsedMilliseconds);
        }
    }
}
