public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //numbers = numbers.Where(n => n < target).ToArray();
        
        for(var i = 0; i < numbers.Length; i++){
            for(var j = i+1; j < numbers.Length; j++){
                if(numbers[i] + numbers[j] == target)
                    return new int[] {i+1, j+1};
                    
            }
        }
        return new int[0];
    }
}