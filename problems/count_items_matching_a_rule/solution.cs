public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int cnt = 0;
        foreach(var item in items){
            
            if(ruleKey == "type" && ruleValue == item[0])
                cnt++;
            else if(ruleKey == "color" && ruleValue == item[1])
                cnt++;
            else if(ruleKey == "name" && ruleValue == item[2])
                cnt++;
            
            /*
            if(ruleKey == "type"){
                if(ruleValue == item[0])
                    cnt++;
            }
            else if(ruleKey == "color"){
                if(ruleValue == item[1])
                    cnt++;
            }
            else if(ruleKey == "name"){
                if(ruleValue == item[2])
                    cnt++;
            }
            */
        }
        return cnt;
    }
}