public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        var total = 0;
        for(var i = 0; i < nums.Length; i+=2)
            total += nums[i];
        return total;
    }
}