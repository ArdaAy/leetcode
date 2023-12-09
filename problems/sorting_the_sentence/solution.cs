public class Solution {
    public string SortSentence(string s) {
        var str = "";
        var strSplit = s.Split(" ");
        
        for(var i = 0; i < strSplit.Length; i++){
            var found = false;

            for(var j = 0; j < strSplit.Length; j++){
                if(strSplit[j].Contains(""+(i+1))){
                    found = true;
                    if(str != "")
                        str += " " + strSplit[j].Replace(""+(i+1),"");
                    else
                        str += strSplit[j].Replace(""+(i+1),"");
                }
                if(found)
                    break;
            }
        }
        return str;
    }
}