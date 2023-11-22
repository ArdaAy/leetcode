public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        else{
            List<int> iList = new List<int>();

            for (; x != 0; x /= 10)
                iList.Add(x % 10);

            List<int> iListRev = new List<int>(iList);
            iListRev.Reverse();
            return Enumerable.SequenceEqual(iList, iListRev);
        }
    }
}