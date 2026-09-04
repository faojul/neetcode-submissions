public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n =  nums.Length;
        int[] answers = new int[n];

        //prefix product
        answers[0]=1;

        for(int i=1;i<n;i++)
        {
            answers[i]=answers[i-1]*nums[i-1];
        }

        //suffix product
        int suffix = 1;
        for(int i=n-1;i>=0;i--)
        {
            answers[i]=answers[i]*suffix;
            suffix = suffix * nums[i];
        }

        return answers;
    }
}
