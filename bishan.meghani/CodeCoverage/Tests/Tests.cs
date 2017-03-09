using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeCoverage;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        
        public void TestMethod()
        {
            //ARRANGE
            Calculator calc = new Calculator();

            //ACT

            int result = calc.Add(1,1);

            //ASSERT

            Assert.AreEqual(2, result);

        }     
    }
}
