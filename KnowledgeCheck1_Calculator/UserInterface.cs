using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    internal class UserInterface
    {
        private string _operationTipe;
        private string _operationResult;
        public int[] _numbers;
        private Dictionary<string, char> _sign;

        public UserInterface(string operationTipe)
        {
            _operationTipe = operationTipe;
            _sign = new Dictionary<string, char>()
            {
                ["1"] = '+',
                ["2"] = '-',
                ["3"] = '*',
                ["4"] = '/'
            };
        }

        public void GetValuesFromUser(int countOfValues = 2)
        {
            int[] numbers = new int[countOfValues];
            Console.WriteLine($"Please enter {countOfValues} integer values:");
            for (int i = 0; i < countOfValues; i++)
            {
                numbers[i] = InputValidation.GetIntValue();
            }
            _numbers = numbers;
        }

        public string PerformOperation()
        {
            switch (_operationTipe)
            {
                case "1":
                    return Calculator.Add(_numbers).ToString();
                case "2":
                    return Calculator.Subtract(_numbers).ToString();
                case "3":
                    return Calculator.Multiply(_numbers).ToString();
                case "4":
                    return Calculator.Divide(_numbers).ToString();
                default:
                    throw new NotImplementedException();
            }
        }

        public void DisplayResult()
        {
            _operationResult = PerformOperation();
            string messageToDisplay = "";
            foreach (int number in _numbers)
            {
                if (messageToDisplay == "")
                {
                    messageToDisplay = number.ToString();
                }
                else
                {
                    messageToDisplay += $" {_sign[_operationTipe]} " + number.ToString();
                }
            }

            messageToDisplay += $" = {_operationResult}";
            Console.WriteLine(messageToDisplay);
        }
    }
}
