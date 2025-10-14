namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        if (word == null || word.Length == 0)
        {
            return false;
        }
        string wordLowered = word.ToLower();
        string wordReverse = "";
        for (int i = wordLowered.Length - 1; i >= 0; i--)
        {
            wordReverse += wordLowered[i];
        }
        if (word.ToLower() == wordReverse)
        {
            return true;
        } return false;
    }
}