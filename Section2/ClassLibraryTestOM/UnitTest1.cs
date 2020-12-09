using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTestOM
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = ClassLibraryPractice.Class1.Addition(3, 4);
            Assert.AreEqual(result, 7);

        }
    }
}
