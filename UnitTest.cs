using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NaturalSort
{
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SimpleList()
        {
            var list = new List<string>
                {
                    "0.12",
                    "12",
                    "0.012",
                    "10",
                    "Potato",
                    "1.2",
                    "1",
                    "1.2E-4",
                    "0.0012",                
                };

            list.Sort(new NaturalSortComparer<string>());

            Assert.AreEqual(list[0], "1.2E-4");
            Assert.AreEqual(list[1], "0.0012");
            Assert.AreEqual(list[2], "0.012");
            Assert.AreEqual(list[3], "0.12");
            Assert.AreEqual(list[4], "1");
            Assert.AreEqual(list[5], "1.2");
            Assert.AreEqual(list[6], "10");
            Assert.AreEqual(list[7], "12");
            Assert.AreEqual(list[8], "Potato");
        }

        [TestMethod]
        public void ComplexList()
        {
            var o1 = new { Id = 1, Value = "0.01" };
            var o2 = new { Id = 2, Value = "12" };
            var o3 = new { Id = 3, Value = "1" };
            var o4 = new { Id = 4, Value = "10" };

            var list = new[] { o1, o2, o3, o4 }.ToList();

            list = list.OrderByNatural("Value").ToList();

            Assert.AreEqual(list[0].Value, "0.01");
            Assert.AreEqual(list[1].Value, "1");
            Assert.AreEqual(list[2].Value, "10");
            Assert.AreEqual(list[3].Value, "12");
        }
    }
}
