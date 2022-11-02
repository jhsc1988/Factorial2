using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
using Vsite.Pood;
namespace UnitTests
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void MethodReturn1ForArgument1()
        {
            Assert.AreEqual(1, Math.Factorial(1));
        }

        [TestMethod]
        public void MethodReturn2ForArgument2()
        {
            Assert.AreEqual(2, Math.Factorial(2));
        }

        [TestMethod]
        public void MethodReturn6ForArgument3()
        {
            Assert.AreEqual(6, Math.Factorial(3));
        }

        [TestMethod]
        public void MethodReturn120ForArgument5()
        {
            Assert.AreEqual(120, Math.Factorial(5));
        }

        [TestMethod]
        public void MethodReturn1ForArgument0()
        {
            Assert.AreEqual(1, Math.Factorial(0));
        }

        [TestMethod]
        public void MethodThrowsExceptionForNegativeArgument()
        {
            try
            {
                Math.Factorial(-1);
                Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                Assert.IsTrue(true);
                Assert.IsTrue(e.Message.StartsWith(Math.NegativeArgument));
                Assert.AreEqual(-1, (int)e.ActualValue);
            }
        }       
        
        [TestMethod]
        public void MethodThrowsExceptionForATooLargeArgument()
        {
            try
            {
                Math.Factorial(120);
                Assert.Fail();
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
