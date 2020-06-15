//Given an integer array nums, find the contiguous subarray(containing at least one number) 
    //    which has the largest sum and return its sum.
public class Solution
    {

        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int maxCurr = max;//max with current element
            for (int i = 1; i < nums.Length; i++)
            {
                maxCurr = maxCurr < 0 ? nums[i] : maxCurr + nums[i];
                max = Math.Max(max, maxCurr);
            }
            return max;
        }

    }
