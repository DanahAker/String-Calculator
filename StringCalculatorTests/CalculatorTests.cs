﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void addNoNumbersTest()
        {
            //--Arrange
            Calculator calculator = new Calculator();
            
            int expected = 0;

            //--Act
            int actual = calculator.add("");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addOneNumberTest()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 2;

            //--Act
            int actual = calculator.add("2");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addTwoNumbersTest()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 4;

            //--Act
            int actual = calculator.add("1,3");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addNumbersTest()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 5;

            //--Act
            int actual = calculator.add("1,3,3,-2");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addNumbersWithNewLineSeparatorTest()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 2;

            //--Act
            int actual = calculator.add("1,3\n-2");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addNumbersWithDifferentDelimitersTest()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 3;

            //--Act
            int actual = calculator.add("//;\n1;2");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addNumbersWithDifferentDelimitersTest2()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 7;

            //--Act
            int actual = calculator.add("//;\n1;2;4");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void addNumbersWithDifferentDelimitersTest3()
        {
            //--Arrange
            Calculator calculator = new Calculator();

            int expected = 7;

            //--Act
            int actual = calculator.add("//;\n1;2\n4");

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}