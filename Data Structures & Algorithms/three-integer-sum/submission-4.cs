public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new();

        for(int i=0;i<nums.Length;i++)
        {
            //After Sorting, if first one is greater than zero, then
            //All are positive & can be summed to zero
            if(nums[i]>0) break;
            //Duplicate Skip
            if(i>0 && nums[i-1]==nums[i]) continue;

            int l = i+1;
            int r = nums.Length-1;

            while(l<r)
            {
                int sum = nums[i]+nums[l]+nums[r];

                if(sum>0)
                {
                    r--;
                }
                else if(sum<0)
                {
                    l++;
                }
                else
                {
                    result.Add(new List<int>{nums[i],nums[l],nums[r]});

                    //Duplicate Skip left
                    while(l<r && nums[l] == nums[l+1])l++;

                    ////Duplicate Skip Right
                    while (l < r && nums[r] == nums[r - 1]) r--;

                    l++;
                    r--;
                }
            }
        }
        return result;
        
    }
}
