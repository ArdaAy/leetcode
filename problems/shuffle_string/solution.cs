public class Solution {
    public string RestoreString(string s, int[] indices) {
        var cArr = new char[s.Length];
        for(var i = 0; i < indices.Length; i++)
            cArr[indices[i]] = s[i];
        return new string(cArr);
    }
}