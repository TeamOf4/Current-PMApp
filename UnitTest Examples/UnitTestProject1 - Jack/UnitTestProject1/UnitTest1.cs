using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldBeTheSameString()
        {
            //ARRANGE

            var checker = new StringChecker.StringTest();
            
            //ACT

            var result = checker.CheckString("test", "test");

            //ASSERT

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void testStringAredifferent()
        {
            //ARRANGE

            var checker = new StringChecker.StringTest();

            //ACT

            var result = checker.CheckString("test1", "test2");

            //ASSERT

            Assert.AreNotEqual(true ,result);
        }
        [TestMethod]
        public void testStringAredifferent()
        {
            //ARRANGE

            var checker = new StringChecker.StringTest();

            //ACT

            var result = checker.CheckString("test1", "test2");

            //ASSERT

            Assert.AreNotEqual(true, result);
        }


         



    
    }
}
