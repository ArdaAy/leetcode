public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if(needle.Length > haystack.Length)
            return -1;

        for(var i = 0; i < haystack.Length; i++)
        {
            bool isSame = true;
            for(var j = 0; j < needle.Length; j++)
            {
                if(i + j >= haystack.Length)
                {
                    isSame = false;
                    break;
                }
                else if (haystack[i + j] != needle[j])
                {
                    isSame = false;
                    break;
                }
            }
            if (isSame)
                return i;
        }
        return -1;

    }
}