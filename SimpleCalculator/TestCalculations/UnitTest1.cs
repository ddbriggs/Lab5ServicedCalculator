using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestAdd()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Add(2.0, 2.0);
            Assert.AreEqual(4.0, d);
        }

        [TestMethod]
        public void TestSubtrct()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Subtrct(2.0, 2.0);
            Assert.AreEqual(0.0, d);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Multiply(2.0, 2.0);
            Assert.AreEqual(4.0, d);
        }

        [TestMethod]
        public void TestDivide()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var quotient = calcRef.Divide(1, 1);
            Assert.AreEqual(1, quotient);
        }

        [TestMethod]
        public void SqrRootTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var root = calcRef.SqrRoot(9);
            Assert.AreEqual(3, root);

        }

        [TestMethod]
        public void HalveTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var halve = calcRef.Halve(10);
            Assert.AreEqual(5, halve);
        }

        [TestMethod]
        public void QuarterTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var quarter = calcRef.Quarter(20);
            Assert.AreEqual(5, quarter);
        }
    }
}
