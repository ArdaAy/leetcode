public class Solution {
    public int FindSpecialInteger(int[] arr) {
        if(arr.Length == 0)
            return 0;
        else if(arr.Length == 1)
            return arr[0];

        var val = arr[0];
        var cnt = 0;
        for(var i = 0; i < arr.Length; i++){
            if(arr[i] == val)
                cnt++;
            else{
                val = arr[i];
                cnt = 1;
            }
            if(cnt > arr.Length / 4)
                return val;
        }
        return 0;
    }
}