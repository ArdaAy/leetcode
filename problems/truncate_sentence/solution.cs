public class Solution {
    public string TruncateSentence(string s, int k) {
        var splitStr = s.Split(" ");
        var str = "";
        for(var i = 0; i < k; i++){
            if(str=="")
                str += splitStr[i];
            else
                str += " "+splitStr[i];
        }
        return str;
    }
}