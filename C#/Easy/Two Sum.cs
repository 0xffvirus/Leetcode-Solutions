public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for (int q = 0; q < nums.Length; q++) {
            for (int j = 0; j < nums.Length; j++) {
                if (nums[q] + nums[j] == target && q != j) {
                    return [q, j];
                }
            }
        }
        return [0];
    }
}
