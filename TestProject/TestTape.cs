using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapeEquilibirium;

namespace TestProject
{
    [TestFixture]
    public class TestTape
    {
        [Test]
        public void TestOddNumberOut_returnsOddNumber()
        {
            int[] A = { 3,1,2,4,3 };
            TapeClass tapeCLass = new TapeClass();
            Assert.AreEqual(1, tapeCLass.solution(A));
        }
    }
}
