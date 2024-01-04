﻿// https://leetcode.com/problems/merge-sorted-array

using System;
namespace LeetCodeProblems
{
    public class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for(int i = 0; i < n; i++)
            {
                nums1[i + m] = nums2[i];
            }

            Array.Sort(nums1);
        }
    }
}
