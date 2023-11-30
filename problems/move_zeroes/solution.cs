public class Solution {
    public void MoveZeroes(int[] nums) {
        
        if (nums.Length <= 1)
            return;
        
        var copyIndex = 0;
        var copyStart = false;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] == 0 && !copyStart){
                copyStart = true;
                copyIndex = i;
                continue;
            }
            if(nums[i] != 0 && copyStart){
                nums[copyIndex] = nums[i];
                
                copyIndex++;
                if(i != 0)
                    nums[i] = 0;
            }
        }
    }
}