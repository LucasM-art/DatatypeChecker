using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoopsAndSwitchStatementsChallenge
{
    internal class Text
    {
        private string text1 = "Enter a value: ";
        private string text2 = "Select  the data type to validate the input you have entered: ";

        private string validText = "It's a valid: ";
        private string invalidText = "It's an invalid: ";

        public string Text1
        {
            get { return text1; }
        }

        public string Text2
        {
            get { return text2; }
        }

        public string ValidText
        {
            get { return validText; }
        }

        public string InvalidText
        {
           get { return invalidText; }
        }
    }
}
