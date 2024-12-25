public class Solution {
    public bool RotateString(string s, string goal) {
        if (s.Length != goal.Length)
            return false;
        string ss = s + s;
        return ss.Contains(goal);
    }
}