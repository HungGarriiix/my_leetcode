public class Solution {
    public int FindDuplicate(int[] nums) {
        List<int> finding_num = new List<int>();
        foreach (int num in nums)
        {
            if (finding_num.Contains(num))
                return num;
            finding_num.Add(num);
        }
        return -1;
    }
}