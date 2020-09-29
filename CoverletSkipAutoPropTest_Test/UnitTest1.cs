using CoverletSkipAutoPropsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverletSkipAutoPropTest_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Class1();

            var result = sut.DoFunnyThings();

            Assert.IsTrue(result);
        }
    }
}
