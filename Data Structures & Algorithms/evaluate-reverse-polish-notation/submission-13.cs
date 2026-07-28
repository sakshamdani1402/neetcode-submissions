public class Solution {
    private int Calculate(string token, int a, int b) {
        return token switch {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
             _   => 0
        };
    }
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new();
        foreach(string token in tokens) {
            if(token is "+" or "-" or "*" or "/") {
                int a = st.Pop();
                int b = st.Pop();

                int result = Calculate(token, b, a);
                st.Push(result);
            } else {
                st.Push(int.Parse(token));
            }
        }
        return st.Peek();
    }
}
