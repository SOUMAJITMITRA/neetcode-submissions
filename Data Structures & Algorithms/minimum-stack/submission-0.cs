public class MinStack {

    Stack<int> st = new Stack<int>();
    Stack<int> minStack =  new Stack<int>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
       if (minStack.Count == 0 || val <= minStack.Peek())
            minStack.Push(val);
        st.Push(val);
    }
    
    public void Pop() {
        if (st.Peek() == minStack.Peek())
            minStack.Pop();
        st.Pop();
    }
    
    public int Top() {
       return st.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek() ;
    }
}
