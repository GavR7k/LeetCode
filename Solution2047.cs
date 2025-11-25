using static System.Net.Mime.MediaTypeNames;

public class Solution
{
    public int CountValidWords(string sentence)
    {

        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int result = words.Length;

        foreach (string word in words)
        {
            if (word.Any(char.IsDigit))
            {
                result--;
                continue;
            }

            if (!ContainsOneHyphen(word))
            {
                result--;
                continue;
            }

            if (!PunctuationMarkRule(word))
            {
                result--;
                continue;
            }
        }

        return result;


    }
    public bool PunctuationMarkRule(string word)
    {

        for (int i = 0; i < word.Length; i++)
        {

            if (word[i] == '!' || word[i] == ',' || word[i] == '.')
            {
                if (i == word.Length - 1)
                {
                    return true;
                }
                else return false;
            }

        }
        return true;
    }


    public bool ContainsOneHyphen(string word)
    {
        int hyphenCount = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (hyphenCount > 1) return false;

            if (word[i] == '-' && (i == 0 || i == word.Length - 1)) return false;

            if (word[i] == '-')
            {
                hyphenCount++;
            }
        }
        return true;
    }
}