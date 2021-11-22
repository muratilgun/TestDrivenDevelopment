using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        #region Add1

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

        #endregion
        #region Add2

        // public int Add(string numbers)
        // {
        //     var splitNumbers = numbers
        //         .Split(new[] {','},StringSplitOptions.RemoveEmptyEntries)
        //         .Select(int.Parse);
        //     return splitNumbers.Sum();
        // }

        #endregion
        #region Add3

        // public int Add(string numbers)
        // {
        //     var delimiters = new[] { ',', '\n' };
        //     var splitNumbers = numbers
        //         .Split(delimiters,StringSplitOptions.RemoveEmptyEntries)
        //         .Select(int.Parse);
        //     return splitNumbers.Sum();
        // }

        #endregion
        #region Add4
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

            #region 1. yol

            // var negativeNumbers = new List<int>();
            // foreach (var potentiallyNegativeNumber in splitNumbers)
            // {
            //     if (potentiallyNegativeNumber < 0)
            //     {
            //         negativeNumbers.Add(potentiallyNegativeNumber);
            //     }
            // }

            #endregion
            var negativeNumbers = splitNumbers.Where(x => x < 0).ToList();
            if (negativeNumbers.Any())
            {
                throw new Exception("Negatives not allowed: " + string.Join(",",negativeNumbers));
            }
            
            return splitNumbers.Sum();
        }
        #endregion
    }
}