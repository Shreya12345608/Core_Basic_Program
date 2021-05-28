using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class VowelOrNot
    {
        public char Alphabet;
        public void CheckGivenVowel()
        {
            Console.Write("Check whether the input  Alphabet (A-Z or a-z) is a vowel or not:\n"); //input from user
            Alphabet = Convert.ToChar(Console.ReadLine()); //read Char value given from user
            if (Alphabet == 'a' | Alphabet == 'A' | Alphabet == 'i' | Alphabet == 'I' | Alphabet == 'U' | Alphabet == 'u' | Alphabet == 'E' | Alphabet == 'e' | Alphabet == 'O' | Alphabet == 'o')//check
                Console.WriteLine("Given" + " " + Alphabet + " is a Vowel"); //op if its vowel  {a,e,i,o,u,A,E,I,O,U}
            else
                Console.WriteLine("Given" + " " + Alphabet + " is a Consonant"); // expect  {a,e,i,o,u,A,E,I,O,U}
        }
    }
}