public class Solution {
    public int[] PlusOne(int[] digits) {
        
        if (digits.Length == 0)
            return new int[] { 1 };

        int[] arr = digits;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] + 1 == 10)
            {

                if (i==0)
                {
                    arr[i] = 0;
                    int[] temp = new int[arr.Length + 1];
                    temp[0] = 1;
                    for (var j = 0; j < arr.Length; j++)
                        temp[j + 1] = arr[j];
                    return temp;
                }
                else
                    arr[i] = 0;
            }
            else
            {
                arr[i] = arr[i] + 1;
                return arr;
            }

        }
        return arr;
    }
}