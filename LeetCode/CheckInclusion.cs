namespace LeetCode;

public static class CheckInclusion
{
    
   public static bool IsThereInclusion(string s1, string s2) {
    
        if (s1.Length > s2.Length)
            return false;

        var bucket = new int[26];

        for(var i = 0; i < s1.Length; i++)  {
            bucket[s1[i] - 'a']++;
            bucket[s2[i] - 'a']--;
        }

        if (IsValid(bucket))
            return true;

        for(var i = s1.Length; i < s2.Length; i++) {

            bucket[s2[i] - 'a']--;
            bucket[s2[i - s1.Length] - 'a']++;
        
            if (IsValid(bucket)) 
                return true;
        }

        return false;
    }

   private static bool IsValid(IReadOnlyList<int> bucket) {
    
        for(var i = 0; i < 26; i++) {
            if (bucket[i] != 0) {
                return false;
            }
        }

        return true;
    }
}