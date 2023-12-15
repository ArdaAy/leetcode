public class Solution {
    public IList<string> CellsInRange(string s) {
        char startStr = s[0];
        int startInd = int.Parse(""+s[1]);
        char endStr = s[3];
        int endInd = int.Parse(""+s[4]);
        int tmpCnt = int.Parse(""+s[1]);
        List<string> sList = new List<string>();

        while(true){
            if(tmpCnt <= int.Parse(""+endInd)){
                sList.Add(""+startStr+tmpCnt);
                tmpCnt++;
            }
            else if(startStr < endStr){
                startStr++;
                tmpCnt = startInd;
            }
            else
                break;
        }
        return sList;
    }
}