public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        if(points.Length <= 1)
            return 0;
        
        var time = 0;
        for(var i = 0; i < points.Length - 1; i++){
            while(true){

                if(points[i][0] == points[i+ 1][0] && points[i][1] == points[i+ 1][1])
                    break;

                if(points[i][0] < points[i+ 1][0]){
                    points[i][0] = points[i][0] + 1;
                }
                else if(points[i][0] > points[i+ 1][0]){
                    points[i][0] = points[i][0] - 1;
                }

                if(points[i][1] < points[i+ 1][1]){
                    points[i][1] = points[i][1] + 1;
                }
                else if(points[i][1] > points[i+ 1][1]){
                    points[i][1] = points[i][1] - 1;
                }

                time++;

            }
            

        }
        return time;
    }
}