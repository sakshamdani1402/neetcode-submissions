public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> st = new();
        int[] result = new int[temperatures.Length];
        Array.Fill(result, 0);
        for(int i = temperatures.Length - 1; i >= 0; i--) {

            while(st.Count > 0 && temperatures[i] >= temperatures[st.Peek()]) {
                st.Pop();
            }
            if(st.Count > 0) {
                result[i] = st.Peek() - i;
            }
            st.Push(i);
        }
        return result;
    }
}
