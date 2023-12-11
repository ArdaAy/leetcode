public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) {
            if ( (c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') ) {
                sb.Append(c);
            }
        }
        string str = sb.ToString().ToLower();
        
        var i = str.Length - 1;
        for(var j = 0; j < str.Length; j++ , i--){
            if(str[i] != str[j])
                return false;
        }
        return true;
        
        /*
        var rev = str.ToCharArray();
        Array.Reverse(rev);
        return str == new string(rev);
        */
    }
}