public class Solution {
    public string ConvertToTitle(int columnNumber) {
        // 26 chars in alphabet
        // 65 -> A , 90 -> Z
        var str = "";
            while (columnNumber > 0)
            {
                str = ((char)(65 + ((columnNumber-1) % 26))) + str;
                columnNumber = (columnNumber - 1) / 26;
            }
            return str;
    }
}