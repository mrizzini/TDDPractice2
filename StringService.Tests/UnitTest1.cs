using System;
using System.Collections.Generic;
using NUnit.Framework;
using StringService;

namespace Tests
{
    public class Tests
    {
       
        ICalculatorService _calculatorService = new CalculatorService();

        [Test]
        public void IfEmptyString_ReturnZero()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = " ";
            var expectedResult = 0;
            var result = _testService.StringCalculator(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfSingleNumber_ReturnValue()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = "5";
            var expectedResult = 5;
            var result = _testService.StringCalculator(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfTwoNumbersCommaDelimited_ReturnSum()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = "5, 10";
            var expectedResult = 15;
            var result = _testService.StringCalculator(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfTwoNumbersNewLineDelimited_ReturnSum()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = "5 \n 100";
            var expectedResult = 105;
            var result = _testService.StringCalculator(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfThreeNumbersDelimitedAnyway_ReturnSum()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = "5 \n 100, 100";
            var expectedResult = 205;
            var result = _testService.StringCalculator(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfNegative_ThrowException()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = "-7";
            var expectedResult = Assert.Throws<System.ArgumentException>(() => _testService.StringCalculator(input));
            Assert.IsTrue(expectedResult.Message.Contains("Must be positive number"));
        }

        [Test]
        public void IfNumberGreaterThan1000Ignore()
        {
            TestService _testService = new TestService(_calculatorService);
            var input = "1, 10, 1001";
            var expectedResult = 11;
            var result = _testService.StringCalculator(input);
            Assert.AreEqual(expectedResult, result);

            var input2 = "1, 1001 \n 1000";
            var expectedResult2 = 1001;
            var result2 = _testService.StringCalculator(input2);
            Assert.AreEqual(expectedResult2, result2);
        }

        // [Test]
        // public void IfManyDelimiters_ReturnSum()
        // {
        //     TestService _testService = new TestService();
        //     var input = "//[***]\n1***2***3";
        //     var expectedResult = 6;
        //     var result = _testService.StringCalculator(input);
        //     Assert.AreEqual(expectedResult, result);
        // }

        // [Test]
        // public void TakeInput_TurnToList()
        // {
        //     TestService _testService = new TestService(_calculatorService);
        //     var result = _testService.AgeCalculator(65,60,75,55);
        //     var expectedResult = new List<int> {65,60,75,55};
        //     Assert.AreEqual(expectedResult, result);
        // }

        // [Test]
        // public void MultiplyEachNumByItself_ReturnTotal()
        // {
        //     TestService _testService = new TestService(_calculatorService);
        //     var result = _testService.AgeCalculator(65,60,75,55);
        //     var expectedResult = 16475;
        //     Assert.AreEqual(expectedResult, result);
        // }

        // [Test]
        // public void SquareRootOfTotalAgesMultipliedByItself()
        // {
        //     TestService _testService = new TestService(_calculatorService);
        //     var result = _testService.AgeCalculator(65,60,75,55);
        //     var expectedResult = 128;
        //     Assert.AreEqual(expectedResult, result);
        // }
        
        [Test]
        public void Divide_SquareRootOfTotalAgesMultipliedByItself()
        {
            TestService _testService = new TestService(_calculatorService);
            var result = _testService.AgeCalculator(65,60,75,55);
            var expectedResult = 64;
            Assert.AreEqual(expectedResult, result);
        }
    }
}

// 4225
// 3600
// 5625
// 3025

// An empty string returns zero
// A single number returns the value
// Two numbers, comma delimited, returns the sum
// Two numbers, newline delimited, returns the sum
// Three numbers, delimited either way, returns the sum
// Negative numbers throw an exception
// Numbers greater than 1000 are ignored

