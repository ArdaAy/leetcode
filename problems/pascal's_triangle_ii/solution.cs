public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> bList = new List<int> {1};
        long prev = 1;
        for(var i = 1; i <= rowIndex; i++){
            long next = prev * (rowIndex - i + 1) / i;
            bList.Add((int)next);
            prev = next;
        }
        return bList;
    }
}