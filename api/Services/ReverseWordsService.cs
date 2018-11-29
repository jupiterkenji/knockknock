using System;
using System.Collections.Generic;
using System.Text;

namespace api.Service
{
    public class ReverseWords
    {
        public string Calculate(string words)
        {
            var result = new List<string>();

            foreach (var word in words.Split(' '))
            {
                result.Add(ReverseWord(word));
            }

            return string.Join(" ", result);
        }

        public string ReverseWord(string word)
        {
            var letters = word.ToCharArray();
            var result = new StringBuilder();

            for(var index = letters.Length-1; index >= 0; index--)
            {
                result.Append(letters[index]);
            }

            return result.ToString();
        }
    }
}