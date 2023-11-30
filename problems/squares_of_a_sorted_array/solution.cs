public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(var i = 0; i < nums.Length; i++)
            nums[i] *= nums[i];
        Array.Sort(nums);
        return nums;
    }
}