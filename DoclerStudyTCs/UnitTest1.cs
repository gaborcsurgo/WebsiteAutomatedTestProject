using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoclerStudyTCs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t1 = new TestClass();
            t1.SetUp();
            t1.TheTestClass();
            t1.TeardownTest();
        }
    }
}
