public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> eList = new List<int>();
        List<int> oList = new List<int>();
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] % 2 == 0)
                eList.Add(nums[i]);
            else
                oList.Add(nums[i]);
        }
        var cnt = eList.Count;
        for(var i = 0; i < eList.Count; i++)
            nums[i] = eList[i];
        
        for(var i = 0; i < oList.Count; i++){
            nums[cnt] = oList[i];
            cnt++;
        }
        return nums;
    }
}