public class Solution {
    public IList<string> FizzBuzz(int n) {
        
        List<string> sList = new List<string>();
        for(var i = 1; i <= n; i++){
            if(i % 3 == 0 & i % 5 == 0)
                sList.Add("FizzBuzz");
            else if(i % 3 == 0)
                sList.Add("Fizz");
            else if(i % 5 == 0)
                sList.Add("Buzz");
            else
                sList.Add(""+i);
        }
        return sList;
    }
}