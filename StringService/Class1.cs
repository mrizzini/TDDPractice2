using System;
using System.Collections.Generic;

namespace StringService
{
    public class TestService
    {

        private readonly ICalculatorService _calculatorService;

        public TestService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int StringCalculator(string input)
        {
            if (input.Contains("-"))
                throw new System.ArgumentException("Must be positive number");

            if (String.IsNullOrWhiteSpace(input))
                return 0;

            if (input.Contains(",") || input.Contains("\n"))
            {
                return _calculatorService.Calculate(input);
                // char[] separator =  {',', '\n'};
                // var numbers = input.Split(separator);
                // var sum = 0;
                // foreach (var number in numbers)
                // {
                //     var convertedInt = Convert.ToInt32(number);
                // if (convertedInt <= 1000)
                //     sum += convertedInt;
                // }
                
                // return sum;
            }

            // if (input.Contains(","))
            // {
            //     var numbers = input.Split(',');
            //     var sum = 0;
            //     foreach (var number in numbers)
            //     {
            //         sum += Convert.ToInt32(number);
            //     }
            //     return sum;
            // }

            // if (input.Contains("\n"))
            // {
            //     var numbers = input.Split('\n');
            //     var sum = 0;
            //     foreach (var number in numbers)
            //     {
            //         sum += Convert.ToInt32(number);
            //     }
            //     return sum;
            // }

            return Convert.ToInt32(input);
        }

        public int AgeCalculator(int age1, int age2, int age3, int age4)//, int age5, int age6, int age7, int age8)
        {
            // var ageList = new List<int>();
            // var sumOfAllMultiples = 0;
            // // return age List<int>(age1, age2, age3, age4, age5, age6, age7, age8);
            // ageList.Add(age1);
            // ageList.Add(age2);            
            // ageList.Add(age3);
            // ageList.Add(age4);
            // // ageList.Add(age5);
            // // ageList.Add(age6);
            // // ageList.Add(age7);
            // // ageList.Add(age8);
            // foreach (var age in ageList)
            //     sumOfAllMultiples += age * age;

            // return (Convert.ToInt32(Math.Floor(Math.Sqrt(sumOfAllMultiples)))) / 2;
            var ageArray = new int[]{ age1, age2, age3,age4 };
            var sumOfAllMultiples = 0;

            foreach (var age in ageArray)
                sumOfAllMultiples += age * age;
            
            return (int)Math.Sqrt(sumOfAllMultiples) / 2;
        }

    }
}
