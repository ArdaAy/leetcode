public class Solution {
    public int RemoveDuplicates(int[] nums) {
        List<int> nList = new List<int>();
        for(var i = 0; i < nums.Length; i++){
            bool isThere = false;
            for(var j = 0; j < nList.Count; j++){
                if(nList[j] == nums[i]){
                    isThere = true;
                    break;
                }
            }
            if(!isThere)
                nList.Add(nums[i]);
        }
        for(var i = 0; i < nList.Count; i++)
            nums[i] = nList[i];
        return nList.Count;
    }
}