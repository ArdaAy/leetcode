public class Solution {
    public string RemoveVowels(string s) {
        return string.Join("", s.Where(s => s != 'a' && s!= 'e' && s!= 'i' && s!= 'o' && s!= 'u').ToList());
    }
}