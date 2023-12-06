public class Solution {
    public int MostWordsFound(string[] sentences) {
        var cnt = 0;
        foreach(var str in sentences){
            //var tmp = str.Split(" ").Length;
            if(str.Split(" ").Length > cnt)
                cnt = str.Split(" ").Length;
        }
        return cnt;
    }
}