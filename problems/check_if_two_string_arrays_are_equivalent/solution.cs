public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var str1 = "";
        var str2 = "";
        foreach(var s in word1)
            str1 += s;
        foreach(var s in word2)
            str2 += s;
        return str1.Equals(str2);
    }
}