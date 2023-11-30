public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> iList = new List<int>();
        //Array.Sort(nums);
        for(var i = 0; i < nums.Length; i++){
            var isThere = false;
            for(var j = 0; j <nums.Length; j++){
                if(nums[j] == i+1){
                    isThere = true;
                    break;
                }
            }
            if(!isThere)
                iList.Add(i+1);
        }
        return iList;
    }
}