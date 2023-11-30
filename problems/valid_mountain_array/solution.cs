public class Solution {
    public bool ValidMountainArray(int[] arr) {
        
        if(arr.Length < 3)
            return false;
        
        bool pos = true;
        for(var i = 1; i < arr.Length; i++){
            if(pos){
                if(arr[i - 1] > arr[i]){
                    if(i == 1)
                        return false;
                    else
                        pos = false;
                }
                else if(arr[i - 1] == arr[i])
                    return false;
            }
            else{
                if(arr[i - 1] < arr[i] || arr[i - 1] == arr[i])
                    return false;
            }
        }
        if(pos)
            return false;
        return true;
     }
}