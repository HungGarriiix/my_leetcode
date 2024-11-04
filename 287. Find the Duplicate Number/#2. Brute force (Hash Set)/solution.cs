public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> find_dup = new HashSet<int>();
        foreach(int num in nums)
        {
            if (!find_dup.Add(num))
                return num;
        }
        return -1;
    }
}