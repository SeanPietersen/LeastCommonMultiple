using System;
using System.Collections.Generic;
using System.Linq;

namespace LeastCommonMultiple.App
{
    public class CalculateTheLeastCommonMultiple : ICalculateTheLeastCommonMultiple
    {
        public int gcdCalculator(int num1, int num2)
        {
            if(num2 == 0)
            {
                return num1;
            }
            else
            {
                return gcdCalculator(num2, num1 % num2);
            }
        }

        public int LowestCommonMultiple(List<int> nums)
        {
            return nums.Aggregate((S, Val) => S * Val / gcdCalculator(S, Val));
        }
    }
}
