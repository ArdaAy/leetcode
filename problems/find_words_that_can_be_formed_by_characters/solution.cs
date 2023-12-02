public class Solution {
    public int CountCharacters(string[] words, string chars) {
        //var cList = chars.ToList();
        var total = 0;
        for(var i = 0; i < words.Length; i++){

            var wList = words[i].ToList();
            var cList = chars.ToList();
            var cnt = 0;
            var isSame = true;
            for(var j = 0; j < wList.Count; j++){
                
                bool isThere = cList.Remove(wList[j]);
                if(isThere)
                    cnt++;
                else{
                    isSame = false;
                    break;
                }
            }
            if(isSame)
                total += cnt;
        }
        return total;
    }
}