public int MaxSubArray(int[] nums)
        {
            int i = 0;

            int max = nums[0];

            try
            {
                MoveToNotNegative(ref i, nums, ref max);
            }
            catch { return max; }

            max = nums[i];

            int partMax;

            while (true)
            {
                try
                {
                    MoveToPositive(ref i, nums);
                }
                catch { return max; }

                partMax = GetMaxOfPart(ref i, nums);//pointing first element in next part already (it is positive)

                max = Math.Max(max, partMax);
            }
        }

        private int GetMaxOfPart(ref int i, int[] nums)
        {
            int max = nums[i], 
                sum = nums[i];
            i++;
            while (i <= nums.Length - 1 && sum > 0)
            {
                sum += nums[i];
                max = Math.Max(max, sum);
                i++;
            }
            return max;
        }

        private void MoveToPositive(ref int i, int[] nums)
        {
            while (nums[i] <= 0) { i++; }
        }
        private void MoveToNotNegative(ref int i, int[] nums, ref int maxElement)
        {
            while (nums[i] < 0) {
                maxElement = Math.Max(maxElement, nums[i]); 
                i++; 
            }
        }
