using System;
using System.Collections.Generic;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Dictionary to store the complement of each number and its index
        Dictionary<int, int> complementIndexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            
            // If complement exists in the dictionary, return the indices
            if (complementIndexMap.ContainsKey(complement))
            {
                return new int[] { complementIndexMap[complement], i };
            }
            
            // Otherwise, add current number and its index to the dictionary
            complementIndexMap[nums[i]] = i;
        }
        
        // If no solution is found, return an empty array (this should not happen as per problem statement)
        return new int[0];
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        TwoSumSolution solution = new TwoSumSolution();
        int[] result = solution.TwoSum(nums, target);

        Console.WriteLine($"Indices of the two numbers whose sum is {target}: {result[0]} and {result[1]}");
    }
}
