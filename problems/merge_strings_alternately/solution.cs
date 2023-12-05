public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var cnt = word1.Length >= word2.Length ? word1.Length : word2.Length;
        var str = "";
        for(var i = 0; i < cnt; i++){
            if(i < word1.Length )
                str += word1[i];
            if(i < word2.Length )
                str += word2[i];
        }
        return str;
    }
}