public class Solution {
    public int NumberOfMatches(int n) {
        /*
        var mCnt = 0;
        while(n > 1){
            mCnt += n/2;
            if(n % 2 == 0)
                n /= 2;
            else
                n = (n / 2) + 1;
        }
        return mCnt;
        */
        return n - 1;
    }
}