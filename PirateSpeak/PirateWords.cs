using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateSpeak
{
    public class PirateWords
    {
        public string Words(string pirateWord, List<string> PossibleWords)
        {
            var matchingWords = new List<string>();
            var wordCharacters = pirateWord.ToCharArray();
            foreach (var word in PossibleWords)
            {
                var charWord = word.ToCharArray();
                var differentCharacters = charWord.Except(wordCharacters);
                if (!differentCharacters.Any())
                {
                    matchingWords.Add(word);
                }
            }
            return matchingWords.ToString();
        }
    }
}
