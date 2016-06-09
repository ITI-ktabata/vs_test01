using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace vs_test01.Tests
{
    [TestClass()]
    public class OracleDaoTests
    {
        [TestMethod()]
        public void hogehogeTest()
        {
            String hoge = OracleDao.hogehoge();
            Assert.AreEqual("1000000", hoge, "hogehoge");
        }
    }
}