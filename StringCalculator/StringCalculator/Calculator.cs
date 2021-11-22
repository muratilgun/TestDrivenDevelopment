using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        // public int Add(string numbers)
        // {
        //     var splitNumbers = numbers
        //         .Split(new[] {','},StringSplitOptions.RemoveEmptyEntries);
        //     if (!splitNumbers.Any())
        //     {
        //         return 0;
        //     }
        //
        //     if (splitNumbers.Length ==1)
        //     {
        //         if (splitNumbers[0].Length == 0)
        //         {
        //             return 0;
        //         }
        //
        //         return int.Parse(splitNumbers[0]);
        //     }
        //     return int.Parse(splitNumbers[0]) +int.Parse(splitNumbers[1]);
        // }
        //
        
        // public int Add(string numbers)
        // {
        //     var splitNumbers = numbers
        //         .Split(new[] {','},StringSplitOptions.RemoveEmptyEntries)
        //         .Select(int.Parse);
        //     return splitNumbers.Sum();
        // }
        
        // public int Add(string numbers)
        // {
        //     var delimiters = new[] { ',', '\n' };
        //     var splitNumbers = numbers
        //         .Split(delimiters,StringSplitOptions.RemoveEmptyEntries)
        //         .Select(int.Parse);
        //     return splitNumbers.Sum();
        // }
        
        public int Add(string numbers)
        {
            var delimiters = new List<char>{ ',', '\n' };
            if (numbers.StartsWith("//"))
            {
                var splitOnFirstNewLine = numbers.Split(new[] { '\n' },2);
                var customDelimiter = splitOnFirstNewLine[0].Replace("//", string.Empty).Single();
                delimiters.Add(customDelimiter);
                numbers = splitOnFirstNewLine[1];
            }
            
            var splitNumbers = numbers
                .Split(delimiters.ToArray(),StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            return splitNumbers.Sum();
        }
    }
}