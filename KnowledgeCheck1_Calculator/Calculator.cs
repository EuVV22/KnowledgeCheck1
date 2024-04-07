using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public static int Add(int[] numbers)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                result += i;
            }
            return result;
        }

        public static int Subtract(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length;i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static int Multiply(int[] numbers)
        {
            int result = 1;
            foreach (int i in numbers)
            {
                result *= i;
            }
            return result;
        }

        public static double Divide(int[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length;i++)
            {
                result /= numbers[i];
            }
            return result;
        }

        
    }
}
