﻿using System;
using FluentAssertions;
using Xunit;

namespace StringCalculator.Test
{
    public class CalculatorTests
    {
        #region TEST 1

        [Theory]
        [InlineData("",0)]
        [InlineData("1",1)]
        [InlineData("1,2",3)]
        public void Add_AddsUpToTwoNumber_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Add(calculation);
            // Assert
            result.Should().Be(expected);
        }

        #endregion

        #region TEST 2

        [Theory]
        [InlineData("1,2,3",6)]
        [InlineData("10,90,10,20",130)]
        public void Add_AddsUpToAnyNumber_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Add(calculation);
            // Assert
            result.Should().Be(expected);
        }

        #endregion

        #region TEST 3

        [Theory]
        [InlineData("1\n2,3",6)]
        [InlineData("10\n90,10\n20",130)]
        public void Add_AddsNumbersUsingNewLineDelimiter_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Add(calculation);
            // Assert
            result.Should().Be(expected);
        }

        #endregion

        #region TEST 4

        [Theory]
        [InlineData("//;\n1;2",3)]
        [InlineData("//;\n1;2;4",7)]
        public void Add_AddsNumbersUsingCustomDelimiter_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Add(calculation);
            // Assert
            result.Should().Be(expected);
        }

        #endregion

        #region TEST 5

        [Theory]
        [InlineData("1,2,-1","-1")]
        [InlineData("//;\n1;-2;-4","-2,-4")]
        public void Add_ShouldThrownAnExcepiton_WhenNegativeNumbersAreUsed(string calculation, string negativeNumbers)
        {
            // Arrange
            var sut = new Calculator();
            // Act
            Action action = () => sut.Add(calculation);
            // Assert
            action.Should().Throw<Exception>().WithMessage("Negatives not allowed: " + negativeNumbers);
        }

        #endregion
    }
}