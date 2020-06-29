using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sfigure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sfigure.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void AreaTest_3_4_5_6Returned()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            double result = Convert.ToDouble(Sfigure.Triangle.Area(a, b, c));
            double actual = 6;

            Assert.AreEqual(result, actual);

        }
    }
}