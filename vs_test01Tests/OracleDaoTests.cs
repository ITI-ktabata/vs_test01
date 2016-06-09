using Microsoft.VisualStudio.TestTools.UnitTesting;
using vs_test01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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