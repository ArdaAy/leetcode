public class Solution {
    public string ReverseWords(string s) {
        var strList = s.Trim().Split(" ").Where(s => s != "").ToArray();
        Array.Reverse(strList);
        return string.Join(" ", strList);
    }
}