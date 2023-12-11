public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        
        int start = 0;
        int end = 0;
        int sum = nums[0];
        int len = int.MaxValue;
        while(end < nums.Length){
            if(sum < target){
                end++;
                if(end < nums.Length)
                    sum += nums[end];
            }
            else{
                len = Math.Min(len, end - start + 1);
                sum -= nums[start];
                start++;
            }
        }
        return len == int.MaxValue ? 0 : len;
    }
}