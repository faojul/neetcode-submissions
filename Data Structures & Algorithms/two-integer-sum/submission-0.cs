public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> store = new Dictionary<int,int>(nums.Length);

        for(int i=0;i<nums.Length;i++)
        {
            var remaining = target - nums[i];
            if(store.ContainsKey(remaining))
                return i<store[remaining] ? new int[]{i,store[remaining]}: new int[]{store[remaining],i};
            else
                store[nums[i]]=i;
        }
        return new int[]{};
    }
}
