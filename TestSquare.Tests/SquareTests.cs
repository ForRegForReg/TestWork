﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSquare;
namespace TestSquare.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TriangleSquareTest()
        {
            double a = 5;
            double b = 4;
            double c = 3;
            double ExpectedValue = 6;

            Triangle tri = new Triangle(a, b, c);
            double ActualValue = tri.CalculateSquare();

            Assert.AreEqual(ExpectedValue, ActualValue);

        }

        [TestMethod]
        public void IsRectangularTest()
        {
            double a = 5;
            double b = 4;
            double c = 3;
            bool ExpectedValue = true;

            Triangle tri = new Triangle(a, b, c);
            bool ActualValue = tri.IsRectangular;

            Assert.AreEqual(ExpectedValue, ActualValue);            
        }

        [TestMethod]
        public void CircelSquareTest()
        {
            double r = 2;
            double ExpectedValue = 12.56;

            Circle cir = new Circle(r);
            double ActualValue = cir.CalculateSquare();

            Assert.AreEqual(ExpectedValue, ActualValue);

        }

    }
}