namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        if (word == null || word.Length == 0)
        {
            return false;
        }
        string wordReverse = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            wordReverse += word[i];
        }
        if (word == wordReverse)
        {
            return true;
        }
        else return false;
    }
}