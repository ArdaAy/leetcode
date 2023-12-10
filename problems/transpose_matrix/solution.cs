public class Solution {
    public int[][] Transpose(int[][] matrix) {
        if(matrix.Length == 0)
            return new int[0][];

        int[][] arr = new int[matrix[0].Length][];

        for(var i = 0; i < matrix[0].Length; i++)
            arr[i] = new int[matrix.Length];

        for(var i = 0; i < matrix[0].Length; i++)
        {
            for(var j = 0; j < matrix.Length; j++)
            {
                arr[i][j] = matrix[j][i];
            }
        }

        return arr;
    }
}