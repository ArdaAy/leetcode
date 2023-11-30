public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var tmp = 0;
        for(var i = 0;i < nums.Length; i++){
            if(nums[i] == 1)
                tmp++;
            else
                tmp = 0;
            
            if(tmp > max){
                max = tmp;
            }
        }
        return max;
    }
}