public class Solution {
    public string LargestGoodInteger(string num) {
        var last = "";
        for(var i = 9; i >= 0; i--){
            var str = i + "" + i + "" + i;
            if(num.Split(str).Length > 1)
                return str;
        }
        return last;
    }
}