public class Solution {
    public string LargestOddNumber(string num) {
        
        if(int.Parse(num.Substring(num.Length -1, 1)) % 2 == 1)
            return num;
        
        for(var i = num.Length -1; i >= 1; i--){
            int tmp = 0;
            if (int.TryParse(""+num.Substring(i, 1), out tmp))
            {
                if (tmp % 2 == 1 )
                    return num.Substring(0, i+1);
            }
        }

        var total = 0;
        for(var i = 0; i < num.Length; i++)
        {
            int tmp = 0;
            if (int.TryParse(""+num[i], out tmp))
            {
                if (tmp % 2 == 1 && tmp > total)
                    total = tmp;
            }
        }
        if(total > 0)
            return total.ToString();
        else
            return "";
    }
}