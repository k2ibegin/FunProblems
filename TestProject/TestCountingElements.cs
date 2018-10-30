
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountingElements;

namespace TestProject
{
    [TestFixture]
    public class TestCountingElements
    {
        [Test]
        public void TestCountingElements_returnsarraywithCounts()
        {
            int[] A = { 3,4,4,6,1,4,4 };
            CountingElementsSolution countingClass = new CountingElementsSolution();
            int[] B = { 3, 2, 2, 4, 2 };
            Assert.AreEqual(B, countingClass.Solution(5, A));
        }
    }
}
