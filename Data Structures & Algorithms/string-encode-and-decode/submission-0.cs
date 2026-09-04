public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs)
        {
            sb.Append(str.Length).Append("#").Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i=0;
        while(i<s.Length)
        {
            int j=i;
            while(s[j]!='#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i,j-i));
            i=j+1;
            j=i+length;
            result.Add(s.Substring(i,length));
            i=j;
        }
        return result;
   }
}
