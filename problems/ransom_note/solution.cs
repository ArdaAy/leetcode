public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (magazine.Length < ransomNote.Length)
                return false;

            var rList = ransomNote.ToList();
            var mList = magazine.ToList();

            foreach (var ransom in rList)
            {
                var isThere = false;
                foreach (var mag in mList)
                {
                    if (ransom.Equals(mag))
                    {
                        isThere = true;
                        mList.Remove(mag);
                        break;
                    }
                }
                if (!isThere)
                    return false;
            }
            return true;
    }
}