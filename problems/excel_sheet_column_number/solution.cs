public class Solution {
    public int TitleToNumber(string columnTitle) {
        int cnt = 0;
        int col = 0;
        for(var i = columnTitle.Length - 1; i >= 0; i--, col++){
            cnt += (((int)columnTitle[i]) - 64) * ((int)Math.Pow(26, col));
        }
        return cnt;
    }
}