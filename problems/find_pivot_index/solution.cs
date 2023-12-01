public class Solution {
    public int PivotIndex(int[] nums) {
        
        for(var i = 0; i < nums.Length; i++){
            int left = 0;
            int right = 0;
            for(var j = 0; j < i; j++)
                left += nums[j];
            for(var j = nums.Length - 1; j > i; j--)
                right += nums[j];
            if(left == right)
                return i;
        }
        return -1;
    }
}