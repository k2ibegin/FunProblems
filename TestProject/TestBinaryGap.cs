using NUnit.Framework;
using System;
using BinaryGapFirst;

namespace TestProject
{
    [TestFixture]
    public class TestBinaryGap
    {
        [Test]
        public void TestSolution()
        {
            Solution solution = new Solution();
            Assert.AreEqual(5, solution.solution(1041));
            Assert.AreEqual(1, solution.solution(13));
            Assert.AreEqual(3, solution.solution(17));
            Assert.AreEqual(4, solution.solution(74901729));
         
        }
    }
}
