namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        string backwards = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            backwards += word[i];
        }

        if (word == backwards)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}