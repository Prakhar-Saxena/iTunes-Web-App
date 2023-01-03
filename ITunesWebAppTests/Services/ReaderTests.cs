using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReachMobi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReachMobi.Services.Tests
{
    [TestClass()]
    public class ReaderTests
    {
        Reader reader = new Reader();
        [TestMethod()]
        public void GetSearchItemTest()
        {
            Assert.IsNotNull(reader.QueryItunes("Apple"));
        }
    }
}