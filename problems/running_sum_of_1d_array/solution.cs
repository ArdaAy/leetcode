public class Solution {
    public int[] RunningSum(int[] nums) {
        //int[] arr = new int[nums.Length];
        List<int> arr = new List<int>();
        for(var i = 0; i < nums.Length; i++){
            var total = 0;
            for(var j = 0; j <= i; j++){
                total += nums[j];
            }
            //arr[i] = total;
            arr.Add(total);
        }
        return arr.ToArray();
    }
}