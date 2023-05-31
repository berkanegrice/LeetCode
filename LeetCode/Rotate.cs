namespace LeetCode;

public static class Rotate
{
    public static void MakeRotate(int[] nums, int k)
    {
        for(var t = 0; t < k; t++)
        {
            for(var i = nums.Length-1; i > 0; i--)
            {
                (nums[i-1], nums[i]) = (nums[i], nums[i-1]);
            }
        }
    }
}