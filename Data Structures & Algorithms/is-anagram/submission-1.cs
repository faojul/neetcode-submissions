public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
            return false;

        Dictionary<char,int> store = new Dictionary<char,int>(s.Length);

        foreach(char s1 in s)
        {
            if(store.ContainsKey(s1))
                store[s1]++;
            else
                store.TryAdd(s1,1);
        }
        foreach(char t1 in t)
        {
            if(store.ContainsKey(t1))
                store[t1]--;
        }

        foreach(char h1 in store.Keys)
        {
            if(store[h1]>0)
                return false;
        }
        return true;
    }
}
