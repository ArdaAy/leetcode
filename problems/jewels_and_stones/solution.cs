public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var jList = jewels.ToList();
        var sList = stones.ToList();
        var cnt = 0;
        for(var i = 0; i < jList.Count; i++){
            for(var j = 0; j < sList.Count; j++){
                if(sList[j] == jList[i])
                    cnt++;
            }
        }
        return cnt;
    }
}