public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        if(grid.Length == 0)
            return null;
        int[] onesRow = new int[grid.Length];
        int[] onesCol = new int[grid[0].Length];
        
        int[] zerosRow = new int[grid.Length];
        int[] zerosCol = new int[grid[0].Length];

        int[][] ret = new int[grid.Length][];

        for(var i = 0; i < grid.Length; i++){
            int rowOnesCnt = 0;
            int rowZerosCnt = 0;
            for(var j = 0; j < grid[i].Length; j++){
                if(grid[i][j] == 0)
                    rowZerosCnt++;
                else
                    rowOnesCnt++;
            }
            onesRow[i] = rowOnesCnt;
            zerosRow[i] = rowZerosCnt;
        }

        for(var j = 0; j < grid[0].Length; j++){
            int colOnesCnt = 0;
            int colZerosCnt = 0;
            for(var i = 0; i < grid.Length; i++){
                if(grid[i][j] == 0)
                    colZerosCnt++;
                else
                    colOnesCnt++;
            }
            onesCol[j] = colOnesCnt;
            zerosCol[j] = colZerosCnt;
        }
        for(var i = 0; i < grid.Length; i++){
            ret[i] = new int[grid[i].Length];
            for(var j = 0; j < grid[i].Length; j++){
                ret[i][j] = onesRow[i] + onesCol[j] - zerosRow[i] - zerosCol[j];
            }
        }
        return ret.ToArray();
    }
}