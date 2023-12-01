public class Solution {
    public int TwoSumLessThanK(int[] nums, int k) {
        var max = -1;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] < k){
                for(var j = 0; j < nums.Length; j++){
                    int tmp = nums[i] + nums[j];
                    if(i != j && tmp < k && tmp > max)
                        max = tmp;
                }
            }
        }
        return max;
    }
}