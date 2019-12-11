using System;
using System.Linq;
using System.Collections.Generic;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
                
            }
            return sum;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            // Declaration of the array
            string[] stringArray;

            // Initialization of array
            stringArray = new string[4] { str1, str2, str3, str4 };

            int shortestString = stringArray.Min(w => w.Length);
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] smallNumber;
            smallNumber = new int[4] { number1, number2, number3, number4 };
            return smallNumber.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            int amountOfEven = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                    amountOfEven++;
                }
            }
            if (amountOfEven == 0)
            {
                return 0;
            }

            double average = sum / amountOfEven;
            return average;
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
