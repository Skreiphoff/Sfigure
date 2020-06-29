using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit.Sdk;

namespace Sfigure.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area_1_PIreturned()
        {
            // arrange 
            double radius = 1;
            string result = Math.PI.ToString();

            // act
            string actual = Sfigure.Circle.Area(radius);

            // assert

            Assert.AreEqual(result, actual);

        }
    }
}
