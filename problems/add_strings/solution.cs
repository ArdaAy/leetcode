public class Solution {
    public string AddStrings(string num1, string num2) {
        var total = "";
        var hand = 0;
        
        var i = num1.Length - 1;
        var j = num2.Length - 1;
        
        while(i >= 0 || j >= 0){
            var inTotal = 0;
            if(i >= 0)
                inTotal += int.Parse(""+num1[i]);
            if(j >= 0)
                inTotal += int.Parse(""+num2[j]);
            
            var nSum = inTotal + hand;
            total = (nSum % 10)+ total;
            hand = nSum / 10;
            
            i--;
            j--;
        }
        if(hand > 0)
            return hand+total;
        return total;
    }
}