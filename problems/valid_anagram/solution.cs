public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
                return false;

            var a1 = s.ToList();
            var a2 = t.ToList();
            for (var i = 0; i < a2.Count; i++)
            {
                if (!a1.Remove(a2[i]))
                    return false;
            }
            return true;
    }
}