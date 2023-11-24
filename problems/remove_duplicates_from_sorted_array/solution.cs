public class Solution {
    public int RemoveDuplicates(int[] nums) {
        List<int> iList = new List<int>();
            
        if (nums.Length > 0)
        {
            int cnt = 1;
            int tmp = nums[0];
            iList.Add(tmp);
            for (var i = 1; i < nums.Length; i++)
            {
                if (tmp != nums[i])
                {
                    cnt++;
                    iList.Add(nums[i]);
                }
                    
                tmp = nums[i];
            }
            for(var i = 0; i < iList.Count; i++)
            {
                nums[i] = iList[i];
            }
            return cnt;

        }
        else
            return 0;
    }
}