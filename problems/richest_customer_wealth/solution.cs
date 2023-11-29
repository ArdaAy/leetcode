public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        foreach(int[] wealth in accounts){
            var total = 0;
            foreach(int num in wealth){
                total += num;
            }
            if(total > max)
                max = total;
        }
        return max;
    }
}