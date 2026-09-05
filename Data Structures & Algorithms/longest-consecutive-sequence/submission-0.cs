public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;

        List<int> starts = new();
        int maxSequence = 1;
        HashSet<int> stores = nums.ToHashSet();
        
        foreach (int num in stores) {
            if (!stores.Contains(num - 1))
                starts.Add(num);
        }
        
        foreach (int start in starts) {
            int next = start + 1;
            int count = 1;
            while (stores.Contains(next)) {
                count++;
                next++;
            }
            if (count > maxSequence) {
                maxSequence = count;
            }
        }
        return maxSequence;
    }
}
