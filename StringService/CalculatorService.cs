using System;

namespace StringService
{
    public class CalculatorService : ICalculatorService
    {
        public int Calculate(string input)
        {
            // "//[***]\n1***2***3";
            // string[] delimiters = {"//", "[", "]", "***"};
            // input = input.Trim(delimiters);

            char[] separator =  {',', '\n'};
            var numbers = input.Split(separator);
            var sum = 0;
            foreach (var number in numbers)
            {
                var convertedInt = Convert.ToInt32(number);
               if (convertedInt <= 1000)
                sum += convertedInt;
            }
            
            return sum;

        }
    }
}