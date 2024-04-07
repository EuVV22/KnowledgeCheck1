using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    internal class InputValidation
    {
        public static bool validateOperationType(string input)
        {
            int operationAsNum;
            if (int.TryParse(input, out operationAsNum))
            {
                if (operationAsNum > 0 && operationAsNum < 5)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetIntValue()
        {
            int result;
            string userInput;
            bool receivedValidInt;
            do
            {
                Console.WriteLine("Enter an integer number:");
                userInput = Console.ReadLine();
                receivedValidInt = int.TryParse(userInput, out result);
                if (!receivedValidInt)
                {
                    Console.WriteLine("The input was not a valid integer, please try again");
                }
            } while (!receivedValidInt);
            return result;
        }
    }

    
}
