// https://leetcode.com/problems/remove-element

using System;

namespace LeetCodeProblems
{
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int beyondUpperBound = 101;
            int replaced = nums.Length;
            
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val )
                {
                    replaced--;
                    nums[i] = beyondUpperBound;
                }
            }

            Array.Sort(nums);

            return replaced;
        }
    }
}
