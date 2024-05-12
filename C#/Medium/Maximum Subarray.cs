public class Solution {
    public int MaxSubArray(int[] nums) {
        float sum1 = 0;
        int sums = 0;
            for (int i = 0; i < nums.Length; i++) {
            sums += nums[i];
            if (sums > sum1) sum1 = sums;
            if (sums < 0) sums = 0;

        }  
        if (sum1 == 0) {
            return nums.Max();
        }        
        

        return (int)sum1;
    }
}
