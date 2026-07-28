public class Solution {
    private bool IsOpen(char c) {
        return c is '(' or '[' or '{';
    }
    private char GetCounter(char c) {
        return c switch {
            ')' => '(',
            ']' => '[',
            _   => '{'
        };
    }
    public bool IsValid(string s) {
        Stack<char> st = new();
        foreach(char c in s) {
            if(IsOpen(c)) {
                st.Push(c);
                continue;
            }
            if(st.Count == 0 || st.Peek() != GetCounter(c)) {
                return false;
            }
            st.Pop();
        }
        return st.Count == 0;
    }
}
