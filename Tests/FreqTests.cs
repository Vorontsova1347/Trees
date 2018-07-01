using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trees;

namespace Tests
{
    [TestClass]
    public class FreqTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> list = new List<string>(new[] { "b", "a", "c", "d", "e", "f" });
            Frequency fr = new Frequency();
            NodeF f = fr.Generate(list);
            Assert.AreNotEqual(f, null);
        }

        [TestMethod]
        public void TestWithDuplicates()
        {
            List<string> list = new List<string>(new[] { "ab", "aa", "c", "d", "e", "e", "f", "f" });
            Frequency fr = new Frequency();
            NodeF f = fr.Generate(list);
            Assert.AreNotEqual(f, null);
        }
    }
}
