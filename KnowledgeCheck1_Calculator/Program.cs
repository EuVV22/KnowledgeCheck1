using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
            var input = Console.ReadLine();

            if (InputValidation.validateOperationType(input))
            {
                UserInterface userInterface = new UserInterface(input);
                userInterface.GetValuesFromUser();
                userInterface.DisplayResult();
            }
            else
            {
                Console.WriteLine("Not a valid input");
            }
        }
    }
}