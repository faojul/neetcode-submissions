public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        //1. Generate Frequency for each number
        Dictionary<int,int> store = new Dictionary<int,int>(nums.Length);
        foreach(int num in nums)
        {
            if(!store.ContainsKey(num))
                store.Add(num,1);
            else
                store[num]++;
        }

        //2. Bucket them by frequency
        List<int> [] buckets = new List<int>[nums.Length+1];
        foreach(var st in store)
        {
            var key = st.Key;
            var value = st.Value; //frequency
            if(buckets[value]==null)
              buckets[value] = new List<int>();
            
            buckets[value].Add(key);
        }

        //3. Cut them by top k elements.
        int[] result = new int[k];
        int index = 0;
        for(int i=buckets.Length-1; index<k && i>=0;i-- )
        {
            if(buckets[i]!=null)
            {
                foreach(int b in buckets[i])
                {
                    result[index++]= b;

                    if(index >= k)
                        return result;
                }
            }

        }
        return result;
    }
}
