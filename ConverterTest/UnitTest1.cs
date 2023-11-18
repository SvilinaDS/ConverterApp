using NUnit.Framework;
using System;

namespace ConverterTest
{
    public class Tests
    {
        [Test]
        public void Do_InputGreaterThan1007_Returns1000()
        {
            float input = 105.8f;
            int result = Converter.Do(input);
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void Do_InputBetween0And1007_ReturnsIntegerPart()
        {
            float input = 45.6f;
            int result = Converter.Do(input);
            Assert.AreEqual(45, result);
        }

        [Test]
        public void Do_InputIsZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Converter.Do(0));
        }

        [Test]
        public void Do_InputBetweenMinus30_4AndZero_ReturnsIntegerPartMinus5()
        {
            float input = -15.3f;
            int result = Converter.Do(input);
            Assert.AreEqual((int)input - 5, result);
        }

        [Test]
        public void Do_InputLessThanOrEqualMinus305_ReturnsMinus2000()
        {
            float input = -35.7f;
            int result = Converter.Do(input);
            Assert.AreEqual(-2000, result);
        }

        [Test]
        public void Do_InputEquals1007_Returns1000()
        {
            float input = 100.7f;
            int result = Converter.Do(input);
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void Do_InputEqualsMinus305_ReturnsMinus2000()
        {
            float input = -30.5f;
            int result = Converter.Do(input);
            Assert.AreEqual(-2000, result);
        }

        [Test]
        public void Do_InputEqualsMinus304_ReturnsIntegerPartMinus5()
        {
            float input = -30.4f;
            int result = Converter.Do(input);
            Assert.AreEqual((int)input - 5, result);
        }

        [Test]
        public void Do_InputBetweenMinus304AndMinus305_ReturnsIntegerPartMinus5()
        {
            float input = -30.45f;
            int result = Converter.Do(input);
            Assert.AreEqual(-2000, result);
        }

        [Test]
        public void Do_InputBetween100And1007_Returns100()
        {
            float input = 100.3f;
            int result = Converter.Do(input);
            Assert.AreEqual(100, result);
        }

        [Test]
        public void Do_InputLessThanMinus305_ReturnsMinus2000()
        {
            float input = -40.2f;
            int result = Converter.Do(input);
            Assert.AreEqual(-2000, result);
        }

        [Test]
        public void Do_InputEquals100_Returns100()
        {
            float input = 100.0f;
            int result = Converter.Do(input);
            Assert.AreEqual(100, result);
        }

    }
}