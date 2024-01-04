// https://leetcode.com/problems/rotate-array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class RotateArraySolution
    {
        public void Rotate(int[] nums, int k)
        {
            if(k > nums.Length)
            {
                k = k % nums.Length;
            }

            var pivotPoint = nums.Length - k;
            var secondHalf = nums.Skip(pivotPoint).Take(nums.Length - pivotPoint).ToArray();
            var firstHalf = nums.Skip(0).Take(pivotPoint).ToArray();
            
            secondHalf.CopyTo(nums, 0);
            firstHalf.CopyTo(nums, secondHalf.Length);
        }
    }
}
