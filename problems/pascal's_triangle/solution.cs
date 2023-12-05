public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        List<List<int>> pList = new List<List<int>>();
        for(var n = 0; n < numRows; n++){
            
            List<int> altList = new List<int>();
            for(var i = 0; i < n+1; i++){
                if(i == 0 || i == n)
                    altList.Add(1);
                else{
                    altList.Add(pList[n-1][i-1] + pList[n-1][i]);
                }
            }
            pList.Add(altList);
        }
        return pList.ToArray();
    }
}