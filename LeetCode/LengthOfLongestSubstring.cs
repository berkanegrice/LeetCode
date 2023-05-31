using System.Text;

namespace LeetCode;

public static class LengthOfLongestSubstring
{
    public static int CalculateLengthOfLongestSubstring(string s) {
        var letters = s.ToCharArray();
        var longest = 0;
        for(var i = 0; i < letters.Length-1; i++)
        {
            var j = i + 1;
            var substring = new StringBuilder();
            substring.Append(letters[i]);
            while(!IsAlreadyHave(substring, letters, j)) 
            {
                substring.Append(letters[j]);
                j++;
            }

            if(longest < substring.Length) {
                longest = substring.Length;
            }
        }
        return letters.Length == 1 ? 1 : longest;
    }

    private static bool IsAlreadyHave(StringBuilder sb, IReadOnlyList<char> letter, int index)
    {
        return letter.Count <= index || sb.ToString().Contains(letter[index]);
    }
}