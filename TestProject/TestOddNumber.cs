using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OddNumberFind;

namespace TestProject
{
    [TestFixture]
    public class TestOddNumber
    {
        [Test]
        public void TestOddNumberOut_returnsOddNumber()
        {
            int[] A = { 13, 3, 9, 3, 9, 9 , 10, 11, 10, 11, 13};
            FindOddNumber findOddnUmber = new FindOddNumber();
            Assert.AreEqual(9, findOddnUmber.FindOddNumberMethod(A));
        }

      
    }
}
