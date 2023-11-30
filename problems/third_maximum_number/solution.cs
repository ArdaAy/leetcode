public class Solution {
    public int ThirdMax(int[] nums) {
        Array.Sort(nums);
        var dArr = nums.Distinct().ToArray();
        
        if(dArr.Length < 3)
            return dArr[dArr.Length - 1];
        else
            return dArr[dArr.Length - 3];
    }
}