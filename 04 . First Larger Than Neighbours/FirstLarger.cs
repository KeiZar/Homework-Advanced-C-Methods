using System;

class FirstLarger
{
    static void Main()
    {
        int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
        int[] sequenceTwo = {1, 2, 3, 4, 5, 6, 6};
        int[] sequenceThree = {1, 1, 1};
        Console.WriteLine(FirstElementLargerNeighbours(sequenceOne));
        Console.WriteLine(FirstElementLargerNeighbours(sequenceTwo));
        Console.WriteLine(FirstElementLargerNeighbours(sequenceThree));

    }

    private static int FirstElementLargerNeighbours(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbours(numbers, i))
            {
                return i;
            }
        }
        return -1;
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
