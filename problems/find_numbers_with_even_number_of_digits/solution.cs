public class Solution {
    public int FindNumbers(int[] nums) {
        var evenCnt = 0;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i].ToString().Length % 2 == 0)
                evenCnt++;
        }
        return evenCnt;
    }
}