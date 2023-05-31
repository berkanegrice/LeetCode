namespace LeetCode;

public static class IsInPermutation
{
    public static bool IsInPerm(char[] subs, int size, int perK, string s1)
    {
        if (size == 1)
            return new string(subs).Contains(s1);
        
        for (var i = 0; i < size; i++) {
            IsInPerm(subs, size - 1, size, s1);
            if (size % 2 == 1)
                (subs[0], subs[size - 1]) = (subs[size - 1], subs[0]);
            else 
                (subs[i], subs[size - 1]) = (subs[size - 1], subs[i]);
        }
        return false;
    }

}