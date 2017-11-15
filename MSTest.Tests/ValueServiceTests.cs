using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Library.Services;

namespace MSTest.Tests
{
    [TestClass]
    public class ValueServiceTests
    {
        [TestMethod]
        public void GetRandomString_Returns8Characters_True()
        {
            var chars = ValueService.GetRandomString();
            Assert.AreEqual(8, chars.Length);
        }
    }
}
