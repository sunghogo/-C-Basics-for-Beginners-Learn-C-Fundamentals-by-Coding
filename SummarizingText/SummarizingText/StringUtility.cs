using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    public class StringUtility 
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < 20)
            {
                return text;
            }
            else
            {
                string[] words = text.Split(' ');
                int totalCharacters = 0;
                List<string> summaryWords = new();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", summaryWords) + "...";
            }
        }
    }
}
}
