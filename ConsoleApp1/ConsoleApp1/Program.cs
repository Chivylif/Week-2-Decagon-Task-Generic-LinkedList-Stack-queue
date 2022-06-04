var index = LastOccurance1.Any(new List<int> { 1, 2, 1, 4, 3 }, 1);

Console.WriteLine(index);

public class LastOccurance1
{
    public static int LastOcurrance(List<int> nums, int digit)
    {
        var index = -1;

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == digit)
                index = i;

        }

        return index;
    }

    public static int FirstOcurrance(List<int> nums, int digit)
    {
        var index = -1;

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == digit)
            {
                index = i;
                break;
            }
        }

        return index;
    }

    public static int Any(List<int> nums, int digit)
    {
        return nums.IndexOf(digit);
    }
}

