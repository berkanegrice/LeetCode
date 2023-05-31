namespace LeetCode;

public class MakeQSort
{
    public static bool ContainsDuplicate(int[] nums) 
    {
        QSort(nums, 0, nums.Length-1);
        foreach(var item in nums) {
            Console.WriteLine(item);
        }
        return false;
    }

    private static void QSort(int[] nums, int low, int high)
    {
        if (low >= high) return;
        var pi = Partition(nums, low, high);
        // recursive call on the left of pivot
        QSort(nums, low, pi - 1);
        // recursive call on the right of pivot
        QSort(nums, pi + 1, high);
    }

    private static int Partition(int[] array, int low, int high) 
    {
        var pivot = array[high];
        var i = (low - 1);
        var temp = 0;

        for (var j = low; j < high; j++)
        {
            if (array[j] > pivot) continue;
            i++;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        temp = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp;

        return (i + 1);
    }
}