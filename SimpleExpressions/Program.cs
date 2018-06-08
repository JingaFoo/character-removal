using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExpressions
{
    public class ValidateInput
    {
        public bool EmptyInput(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return true;
            }

            return false;
        }

        public bool CharacterExists(string word, string character)
        {
            if(word.Contains(character))
            {
                return true;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a word");
            Console.Write("Word: ");
            string word = Console.ReadLine();
            Console.Write("Enter a character to remove: ");
            string character = Console.ReadLine();

            List<string> inputs = new List<string>() { word, character };
            List<bool> inValidInputs = new List<bool>();

            ValidateInput inputToValidate = new ValidateInput();
            
            foreach(string input in inputs)
            {
                if(inputToValidate.EmptyInput(input))
                {
                    inValidInputs.Add(true);
                }
            }

            if (inValidInputs.Contains(true))
            {
                Console.WriteLine("Please fill in a non empty string");
            }
            else if (inputToValidate.CharacterExists(word, character))
            {
                word = word.Replace(character, "");
                Console.WriteLine("New word: {0}", word);
            } else
            {
                Console.WriteLine("Sorry, that character does not exist in the given word!");
            }
           
        }
    }
}
