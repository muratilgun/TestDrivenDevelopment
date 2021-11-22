﻿using FluentAssertions;
using Xunit;

namespace StringCalculator.Test
{
    public class CalculatorTests
    {
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
        
        // //;\n1;2
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
        
    }
}