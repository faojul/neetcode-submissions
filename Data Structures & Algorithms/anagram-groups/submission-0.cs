public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs ==  null || strs.Length == 0)
            return new List<List<string>>();
        Dictionary<string,List<string>> groups = new ();


        foreach(var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);

            string key = new string(charArray);

            if(!groups.ContainsKey(key))
                groups[key] = new List<string>();
            
            groups[key].Add(str);
        }

        return new List<List<string>>(groups.Values);
    }
}
