public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int fIndex, lIndex;
        int len = 0;
        char[] c = s.ToCharArray();
        List<char> list = new List<char>();
        //list.Add(c[0]);

        for(fIndex = 0, lIndex = 0; lIndex < c.Length; )
        {
            if(!(list.Contains(c[lIndex])))
            {
                list.Add(c[lIndex]);
                ++lIndex;
                if(lIndex - fIndex > len) len = lIndex - fIndex;
                continue;
            } else {
                list.RemoveAt(0);
                ++fIndex;
            }
        }
        return len;   
    }
}