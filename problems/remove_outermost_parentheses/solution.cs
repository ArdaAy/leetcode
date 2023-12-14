public class Solution {
    public string RemoveOuterParentheses(string s) {
        Stack<char> stack = new Stack<char>();
        string str = "";
        foreach(char c in s){
            if(c == '(') stack.Push(c);
            if(stack.Count > 1) str += c;
            if(c == ')') stack.Pop();
        }
        return str;
    }
}