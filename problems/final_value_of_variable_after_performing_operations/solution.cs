public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        var total = 0;
        for(var i = 0; i < operations.Length; i++){
            if(operations[i] == "--X" || operations[i] == "X--")
                total--;
            else if(operations[i] == "++X" || operations[i] == "X++")
                total++;
        }
        return total;
    }
}