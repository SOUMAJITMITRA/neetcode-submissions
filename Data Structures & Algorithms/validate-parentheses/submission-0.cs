public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();

        for (int i = 0 ; i < s.Length ; i ++){
            if (st.Count == 0){
                st.Push(s[i]);
            }
            else {
                bool charMatching  = false;
                switch (s[i])
                {
                    case ')':
                        if(st.Peek() == '(')
                            charMatching = true;
                        break;

                    case '}':
                        if(st.Peek() == '{')
                            charMatching = true;
                        break;

                    case ']':
                        if(st.Peek() == '[')
                            charMatching = true;
                        break;

                    default:
                        charMatching = false;
                        break;
                }

                if (charMatching){
                    st.Pop();
                }
                else {
                    st.Push(s[i]);
                }

            }
            


        }
        return st.Count == 0 ;
        
    }
}
