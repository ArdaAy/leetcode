public class Solution {
    public int DominantIndex(int[] nums) {
        //var idx = -1;
        for(var i = 0; i < nums.Length; i++){
            bool isBigger = true;
            for(var j = 0; j < nums.Length; j++){
                if(i != j && nums[i] < nums[j] * 2){
                    isBigger = false;
                    break;
                }
            }
            if(isBigger)
                return i;
        }
        return -1;
    }
}