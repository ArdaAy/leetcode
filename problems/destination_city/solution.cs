public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        
        for(int i = 0; i < paths.Count; i++){
            int cnt = 0;
            for(int j = 0; j < paths.Count; j++){
                if(i != j)
                    if(paths[i][1] == paths[j][0])
                        cnt++;
            }
            if(cnt == 0)
                return paths[i][1];
        }
        return "";
    }
}