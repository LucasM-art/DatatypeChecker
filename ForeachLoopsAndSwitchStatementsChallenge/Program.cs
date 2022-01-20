using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoopsAndSwitchStatementsChallenge
{
    internal class Program
    {
        static Text text = new Text();

        public static string input1;
        public static string input2;
        public static string dataType;

        public static int choiceNumber;
        public static int firstChoice;

        public static bool success;

        static void Main(string[] args)
        {
            string[] options = new string[] { "string", "integer", "boolean" };
            int counter = 1;

            Console.WriteLine(text.Text1);
            input1 = Console.ReadLine();
            success = int.TryParse(input1, out firstChoice);
            Console.WriteLine();

            Console.WriteLine(text.Text2);
            Console.WriteLine();
            foreach (string item in options)
            {
                Console.WriteLine("Press {0} for {1}", counter, item); counter++;
            }
            input2 = Console.ReadLine();
            int.TryParse(input2, out choiceNumber);

            switch (choiceNumber)
            {
                case 1:
                    dataType = "String";
                    break;

                case 2:
                    dataType = "Integer";
                    break;

                case 3:
                    dataType = "Boolean";
                    break;
            }

            if (success && choiceNumber == 2)
            {
                Console.WriteLine(text.ValidText + dataType);
            }
            else if (success)
            {
                Console.WriteLine(text.InvalidText + dataType);
            }
            else if (!success && choiceNumber == 1)
            {
                if (input1.Equals("true") || input1.Equals("false"))
                {
                    Console.WriteLine(text.InvalidText + dataType);
                }
                else
                {
                    Console.WriteLine(text.ValidText + dataType);
                }
            }
            else if (!success && choiceNumber == 3)
            {
                if (input1.Equals("true") || input1.Equals("false"))
                {
                    Console.WriteLine(text.ValidText + dataType);
                }
            }
            else
            {
                Console.WriteLine(text.InvalidText + dataType);
            }

            Console.ReadKey();
        }
    }
}
