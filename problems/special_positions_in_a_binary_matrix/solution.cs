public class Solution {
    public int NumSpecial(int[][] mat) {
        if(mat.Length == 0)
            return 0;
        int[] rowArr = new int[mat.Length];
        int[] colArr = new int[mat[0].Length];
        for(var i = 0; i < mat.Length; i++){
            for(var j = 0; j < mat[i].Length; j++){
                if(mat[i][j] == 1){
                    rowArr[i]++;
                    colArr[j]++;
                }
            }
        }
        var cnt = 0;
        for(var i = 0; i < mat.Length; i++){
            for(var j = 0; j < mat[i].Length; j++){
                if(mat[i][j] == 1){
                    if(rowArr[i] == 1 && colArr[j] == 1)
                        cnt++;
                }
            }
        }
        return cnt;
    }
}