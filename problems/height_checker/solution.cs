public class Solution {
    public int HeightChecker(int[] heights) {
        
        var error = 0;
        int[] exp = new int[heights.Length];
        for(var i = 0; i < exp.Length; i++)
            exp[i] = heights[i];
        
        Array.Sort(exp);
        for(var i = 0; i < heights.Length; i++){
            if(heights[i] != exp[i])
                error++;
        }
        return error;
    }
}