public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        for(var i = 0; i < arr.Length; i++){
            var greatest = 0;
            for(var j = i + 1; j < arr.Length; j++){
                if(arr[j] > greatest)
                    greatest = arr[j];
            }
            arr[i] = greatest;
        }
        arr[arr.Length - 1]  = -1;
        return arr;
    }
}