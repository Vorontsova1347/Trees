using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trees;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<List<Node>> GetPaths()
        {
            List<List<Node>> paths = new List<List<Node>>();
            do
            {
                Tree tree = new Tree(10);
                paths = tree.GetPaths(SumType.NonNegative);

            } while (paths.Count == 0);
            return paths;
        }

        [TestMethod]
        public void TestPathSums()
        {
            var paths = GetPaths();

            Console.WriteLine(paths.Count);
            foreach (var path in paths)
            {
                Console.WriteLine(String.Join(" ", path.Select(x=>x.Weight)));
            }
            Assert.AreNotEqual(0, paths.Count);
        }

        [TestMethod]
        public void TestWriteToFile()
        {
            var paths = GetPaths();
            Tree.WriteToFile(paths, "testOut.txt");
        }
    }
}
