public class Solution {
    public void ReverseString(char[] s) {
        var i = 0;
        var j = s.Length - 1;
        while(i<j){
            var tmp = s[i];
            s[i] = s[j];
            s[j] = tmp;
            i++;
            j--;
        }
        /*
        var ss = new char[s.Length];
        var cnt = s.Length - 1;
        for (var i = 0; i < s.Length; i++, cnt--)
            ss[i] = s[cnt];
        for (var i = 0; i < s.Length; i++)
            s[i] = ss[i];
        */
    }
}