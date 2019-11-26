// Pig Latin Translator
// By: Henry Sagehorn
// This program takes a word or sentence, and translates it into pig latin. It will loop through until
// user decides to exit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinConsoleProject
{
    public class PigLatin
    {
        List<string> sentenceWordList = new List<string>();

        public string PigLatinTranslator(string words)
        {
            const string vowels = "AEIOUaeio";
            string translation = "";
            string finalTranslation = "";
            SentenceReader(words);
            foreach(string wordPart in sentenceWordList) { 
            string word = wordPart.ToUpper();
            int stringLength = word.Length;
            char firstLetters = word[0];
                char secondLetter = ' ';
            if (stringLength > 1)
                {
                   secondLetter = word[1];
                }
                
                
                int letter = vowels.IndexOf(firstLetters);
                int letterTwo = vowels.IndexOf(secondLetter);

            if (letter == -1) 
                {
                if (letterTwo == -1) 
                    {
                    word = word.ToLower();
                    firstLetters = word[0];
                    secondLetter = word[1];
                        if (secondLetter == 'y' && word.Length < 3)
                        {
                            translation = secondLetter + "-" + firstLetters + "ay";
                        }
                        else if(secondLetter == 'y' && word.Length > 2){
                            string temp = word.Substring(1);
                            translation = temp + "-" + firstLetters + "ay";
                        }
                        else
                        {
                            string temp = word.Substring(2);
                            translation = temp + "-" + firstLetters + secondLetter + "ay";
                        }
                    
                }
                else
                {
                    word = word.ToLower();
                    firstLetters = word[0];
                    string temp = word.Substring(1);
                    translation = temp + "-" + firstLetters + "ay";
                }
            }
            else
            {
                word = word.ToLower();               
                translation = word + "-" + "ay";
            }
                
                finalTranslation = finalTranslation + translation + ' ';
            }
            return finalTranslation;
        }

        public string SentenceReader(string sentence)
        {
           string[] wordList = sentence.Split(' ');
            foreach(var word in wordList)
            {
                sentenceWordList.Add(word);
            }
            return null;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            PigLatin PigLatin = new PigLatin();
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter a word or sentence to translate into Pig Latin: ");
            string entry = Console.ReadLine();
                        

            string translation = PigLatin.PigLatinTranslator(entry);

            //Console.Write(entry);
            //Console.Write(" in Pig Latin is: ");
            Console.WriteLine(translation);
                Console.WriteLine("ometimes-say i-ay it-say uietly-qay at-ay ight-nay and-ay ink-thay about-ay ere-whay y-may ife-lay as-hay one-gay ");

            Console.Write("Would you like to translate another word? Enter 'Y' to continue or any key to exit : ");
            string choice = Console.ReadLine();
                Console.WriteLine();
            choice = choice.ToUpper();
            if (choice == "Y")
            {
                    continue;
            }
            else
            {
                    flag = false;
            }
            
                
            }
        }
    }
}
