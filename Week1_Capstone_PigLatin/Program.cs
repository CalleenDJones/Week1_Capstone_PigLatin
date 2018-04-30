using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Capstone_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string WordEnglish;
            string FirstLetter;
      
            string PigVowelWord;
            string PigVowelEnd;
            string PigConsWord;
            string FirstCons;
            string PigConstantEnd = "ay";
            string Vowels = "aeiou";

            //introduction
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            while (true)
            {
                //Prompt user for a word
                Console.WriteLine("Enter a word to be translated into Pig Latin");
                //Convert each word to a lowercase before translating
                WordEnglish = Console.ReadLine().ToLower();
                FirstLetter = WordEnglish.Substring(0, 1);//Looks at first letter
                PigVowelEnd = "way";

                //Verify if WordEnglish begins with a Vowel
                if (FirstLetter == "a" || FirstLetter == "e" || FirstLetter == "i" || FirstLetter == "o" || FirstLetter == "u")
                {
                    //Translate word beginning with a vowel to Pig Latin
                    PigVowelWord = WordEnglish + PigVowelEnd;
                    Console.WriteLine("Your translated word is: " + PigVowelWord);
                   
                }
                else
                {
                    for (int first = 0; first < WordEnglish.Length; first++)
                    {
                        for (int second = 0; second < Vowels.Length; second++)
                        {
                            //Does a certain letter check against any vowels
                            if (WordEnglish[first] == Vowels[second])
                            {
                                FirstCons = WordEnglish.Substring(0, first);
                                PigConsWord = WordEnglish.Substring(first, WordEnglish.Length - first);
                                PigConsWord = PigConsWord + FirstCons + PigConstantEnd; // index, "ay
                                Console.WriteLine("Your translated word is: " + PigConsWord);
                               
                            }
                            
                        }
                    }
                    
                }
                //Allows user the opportunity to continue or to end
                Console.WriteLine("Would you like to continue? Enter y or n?");

                string GoOn = Console.ReadLine().ToLower();
                Console.WriteLine("Press enter to continue.");

                if (GoOn == "n")
                    return;
                Console.ReadKey();
            }
            
        }
    }
}

         
                