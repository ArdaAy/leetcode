public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1)
            return strs[0];
        var cList = strs[0].ToCharArray();
        var maxStr = "";
        for(var i = 1; i <= cList.Length; i++)
        {
            var checkStr = "";
            var isDiff = false;
            for (var j = 0; j < i; j++)
            {
                checkStr += cList[j];
            }
            for(var j = 1; j < strs.Length; j++)
            {
                if(strs[j].Length >= i)
                {
                    if (!(strs[j].Substring(0, i) == checkStr))
                    {
                        isDiff = true;
                        break;
                    }
                }
                else
                {
                    isDiff = true;
                    break;
                }
            }
            if (isDiff)
                break;
            else
                maxStr = checkStr;
        }

        return maxStr;
    }
}