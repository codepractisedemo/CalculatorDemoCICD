using NUnit.Framework;
using NetCoreCalculator;

namespace NUnitTestCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionTestCase()
        {
            NetCoreCalculator.Models.Operation myadd = new NetCoreCalculator.Models.Operation();           
            myadd.NumberA = 2;
            myadd.NumberB = 3;
            myadd.Result = myadd.NumberA + myadd.NumberB;
            Assert.AreEqual(myadd.Result, 5.00);
            //Assert.Pass();
        }
    }
}