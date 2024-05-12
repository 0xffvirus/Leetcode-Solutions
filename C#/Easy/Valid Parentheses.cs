public class Solution {
    public bool IsValid(string s) {
        Stack<char> sk = new Stack<char>();
        foreach (char x in s)
        {
            if (x == '(') sk.Push(x);
            else if (x == '[') sk.Push(x);
            else if (x == '{') sk.Push(x);
            else if (x == ')' && sk.Count() != 0 && sk.Peek() == '(') sk.Pop();
            else if (x == ']' && sk.Count() != 0 && sk.Peek() == '[') sk.Pop();
            else if (x == '}' && sk.Count() != 0 && sk.Peek() == '{') sk.Pop();
            else return false;
        }
        if (sk.Count() == 0) return true; else return false;
         }
}
