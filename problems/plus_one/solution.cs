public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits.Length == 0)
            return new int[0];
        
        List<int> iList = digits.Reverse().ToList();
        //iList[0] = iList[0] + 1;
        
        var hand = 1;
        for(var i = 0; i < iList.Count; i++){
            iList[i] = hand + iList[i];
            hand = 0;
            if(iList[i] >= 10){
                
                hand = iList[i] / 10;
                iList[i] = iList[i] % 10;
            }
            else
                break;
        }
        if(hand > 0)
            iList.Add(hand);
        
        int[] arr = new int[iList.Count];
        
        var j = 0;
        for(var i = iList.Count - 1; i >= 0; i--){
            arr[j] = iList[i];
            j++;
        }
        
        return arr;
    }
}