public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> store = new HashSet<int>(nums.Length);
        foreach(int i in nums)
        {
            if(!store.Add(i))
                return true;
        }
        return false;
    }
}