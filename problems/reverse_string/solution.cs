public class Solution {
    public void ReverseString(char[] s) {
        var ss = new char[s.Length];
        var cnt = s.Length - 1;
        for (var i = 0; i < s.Length; i++, cnt--)
            ss[i] = s[cnt];
        for (var i = 0; i < s.Length; i++)
            s[i] = ss[i];
    }
}