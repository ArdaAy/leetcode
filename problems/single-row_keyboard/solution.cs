public class Solution {
    public int CalculateTime(string keyboard, string word) {
        int total = 0;
        int i = 0;
        int j = 0;
        int wCnt = 0;
        int curr = 0;
        while(wCnt < word.Length){
            // i goes left
            // j goes right
            if(keyboard[curr - i] == word[wCnt]){
                curr = curr - i;
                total += i;
                i = 0;
                j = 0;
                wCnt++;
            }
            else if(keyboard[curr + j] == word[wCnt]){
                curr = curr + j;
                total += j;
                i = 0;
                j = 0;
                wCnt++;
            }
            else{
                if(curr - (i + 1) >= 0)
                    i++;
                if(curr + (j + 1) < keyboard.Length)
                    j++;
            }
        }
        return total;
    }
}