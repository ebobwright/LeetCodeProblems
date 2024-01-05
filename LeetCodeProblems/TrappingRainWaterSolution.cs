using System;

namespace LeetCodeProblems
{
    public class TrappingRainWaterSolution
    {
        public int Trap(int[] height)
        {
            // pre-record highest values to the left
            int[] hvls = new int[height.Length];
            hvls[0] = 0;
            for(int i = 1; i < height.Length; i++)
            {
                hvls[i] = Math.Max(height[i - 1], hvls[i - 1]);     
            }

            // pre-record highest values to the right
            int[] hvrs = new int[height.Length];
            hvrs[height.Length - 1] = 0;
            for (int i = height.Length - 2; i >= 0; i--)
            {
                hvrs[i] = Math.Max(height[i + 1], hvrs[i + 1]);
            }

            var totalWater = 0;
            var currentMaxHeight = 0;
            //check every vertical stack of "water" aside from first and last index becasue no water can pool there
            for(int i = 1; i < height.Length - 1; i++)
            {
                if(hvls[i] > height[i] && hvrs[i] > height[i])
                {
                    totalWater += Math.Min(hvls[i], hvrs[i]) - height[i];
                }                
            }
            return totalWater;
        }                
    }
}
