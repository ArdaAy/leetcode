public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        var tmpArr = new List<int>();
        for(var i = nums.Length - k; i < nums.Length; i++){
            tmpArr.Add(nums[i]);
        }
        for(var i = 0; i < nums.Length - k; i++ ){
            tmpArr.Add(nums[i]);
        }
        for(var i = 0; i < nums.Length; i++)
            nums[i] = tmpArr[i];
    }
}