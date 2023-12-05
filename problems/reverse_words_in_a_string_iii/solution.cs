public class Solution {
    public string ReverseWords(string s) {
        var strList = s.Split(" ");
        for(var i = 0; i < strList.Length; i++){
            var sChar = strList[i].ToCharArray();
            Array.Reverse(sChar);
            strList[i] = new string(sChar);
            
        }
        return String.Join(" ",strList);
    }
}