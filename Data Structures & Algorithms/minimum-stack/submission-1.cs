public class MinStack {
    private Stack<int> st = new();
    private Stack<int> minSt = new();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        st.Push(val);
        int currentMin = minSt.Count > 0 ? minSt.Peek() : val;
        int minVal = Math.Min(val, currentMin);
        minSt.Push(minVal);
    }
    
    public void Pop() {
        st.Pop();
        minSt.Pop();
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minSt.Peek();
    }
}
