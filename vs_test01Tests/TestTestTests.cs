using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace vs_test01.Tests
{
    [TestClass()]
    public class TestTestTests
    {
        TestTest test = new TestTest();
        [TestMethod()]
        public void testestTest()
        {
            String hogehoge = "test";
            String hogehoge2 = test.testest(hogehoge);
            Console.WriteLine(hogehoge + ":" + hogehoge2);
            Assert.AreEqual(hogehoge, hogehoge2, "errorERROR");
            //Assert.Inconclusive("このテストメソッドの正確性を確認します。");

        }
        [TestMethod()]
        public void testestTest2()
        {
            String hogehoge = "test";
            String hogehoge2 = test.testest(hogehoge);
            //hogehoge = hogehoge + "test";
            Console.WriteLine(hogehoge + ":" + hogehoge2);
            Assert.AreEqual(hogehoge, hogehoge2, "errorERROR");
        }
    }
}