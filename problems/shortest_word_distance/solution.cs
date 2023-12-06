public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        if(wordsDict.Length == 0)
            return 0;
        
        var w1Arr = new List<int>();
        var w2Arr = new List<int>();
        for(var i = 0; i < wordsDict.Length; i++){
            if(wordsDict[i] == word1)
                w1Arr.Add(i);
            if(wordsDict[i] == word2)
                w2Arr.Add(i);
        }
        var dist = Math.Abs(w1Arr[0] - w2Arr[0]);
        for(var i = 0; i < w1Arr.Count; i++){
            for(var j = 0; j < w2Arr.Count; j++){
                if(Math.Abs(w1Arr[i] - w2Arr[j]) < dist)
                    dist = Math.Abs(w1Arr[i] - w2Arr[j]);
            }
        }
        return dist;
    }
}