using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    static bool IsLargerThanNeighbours(int[] nums, int i)
    {
        bool larger = false;
        if (i == 0)
        {
            larger = nums[i + 1] < nums[i];
        }
        else if (i > 0 && i < nums.Length - 1)
        {
            larger = nums[i - 1] < nums[i] && nums[i + 1] < nums[i];
        }
        else
        {
            larger = nums[i - 1] < nums[i];
        }
        return larger;
    }
}
