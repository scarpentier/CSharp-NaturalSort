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
                    "Potato",
                    "a0.012",
                    "10",
                    "potato",
                    "b1.2",
                    "a1",
                    "1.2E-4",
                    "0.0012",                
                };

            list.Sort(new NaturalSortComparer<string>());

            Assert.AreEqual("1.2E-4", list[0]);
            Assert.AreEqual("0.0012", list[1]);
            Assert.AreEqual("0.12", list[2]);
            Assert.AreEqual("10", list[3]);
            Assert.AreEqual("12", list[4]);
            Assert.AreEqual("Potato", list[5]);
            Assert.AreEqual("a0.012", list[6]);
            Assert.AreEqual("a1", list[7]);
            Assert.AreEqual("b1.2", list[8]);
            Assert.AreEqual("potato", list[9]);
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

            Assert.AreEqual("0.01", list[0].Value);
            Assert.AreEqual("1", list[0].Value);
            Assert.AreEqual("10", list[0].Value);
            Assert.AreEqual("12", list[0].Value);
        }
    }
}
