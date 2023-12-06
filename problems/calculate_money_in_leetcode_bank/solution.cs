public class Solution {
    public int TotalMoney(int n) {
        var sum = 0;
        for(var i = 0; i < n; i++){
            sum += (((i) % 7)+ 1) + ((i)/ 7);
        }
        return sum;
    }
}