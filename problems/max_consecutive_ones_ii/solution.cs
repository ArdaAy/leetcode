public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        bool zeroFound = false;
        if(nums.Length == 1)
            return 1;
        List<int> cList = new List<int>();
        var cnt = 0;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] != 0)
                cnt++;
            else{
                cList.Add(cnt);
                cnt = 0;
                zeroFound = true;
            }
        }
        if(zeroFound)
            cList.Add(cnt);
        else
            return cnt;
        
        var max = 0;
        for(var i = 0; i < cList.Count - 1; i++){
            var tmp = cList[i] + cList[i + 1] + 1;
            if(max < tmp)
                max = tmp;
        }
        if(max < cList[cList.Count - 1] + 1)
                max = cList[cList.Count - 1] + 1;
        return max;
    }
}