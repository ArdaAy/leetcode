public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> iList = new List<int>();
        var cnt = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                iList.Add(nums[i]);
                cnt++;
            }
        }
        for (var i = 0; i < iList.Count; i++)
            nums[i] = iList[i];
            
        return cnt;
    }
}