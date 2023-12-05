public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if(matrix.Length == 1){
            return matrix[0];
        }
        else if(matrix[0].Length == 1){
            List<int> list = new List<int>();
            for(var k = 0; k < matrix.Length; k++)
                list.Add(matrix[k][0]);
            return list;
        }
        
        var i = 0;
        var j = 0;
        //var iCur = 0;
        //var jCur = 0;
        
        var iMin = 0;
        var jMin = 0;
        var iMax = matrix.Length;
        var jMax = matrix[0].Length;
        var maxCnt = matrix.Length * matrix[0].Length;
        
        List<int> mList = new List<int>();
        
        while(true){
            
            i = iMin;
            j = jMin;
            
            while(j < jMax){
                mList.Add(matrix[i][j]);
                j++;
            }
            j = jMax - 1;
            i++;
            
            while(i < iMax){
                mList.Add(matrix[i][j]);
                i++;
            }
            i = iMax - 1;
            
            iMax--;
            jMax--;
            
            if(iMax == iMin || jMin == jMax)
                break;
            
            while(j-1 >= jMin){
                j--;
                mList.Add(matrix[i][j]);
            }
            iMin++;
            //jMin++;
            
            while(i-1 >= iMin){
                i--;
                mList.Add(matrix[i][j]);
            }
            jMin++;
            
            if(iMin >= iMax && jMin >= jMax)
                break;
            else if(mList.Count == maxCnt)
                break;
        }
        return mList;
    }
}