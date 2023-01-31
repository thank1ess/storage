public class Solution {
    public string Sub(string s, int firstIndex, int lastIndex)
    {
        char[] temp = new char[lastIndex - firstIndex + 1];

        for (int counter = 0, i = firstIndex; i <= lastIndex; i++, counter++)
        {
            temp[counter] = s[i];
        }

        return new string(temp);
    }

    public string LongestPalindrome(string s)
    {
        short sLength = (short)s.Length;
        if (s.Length == 1)
            return s;

        string largest = s[0].ToString();
        short change;

        for (short i = 0; i < sLength - 1 - (largest.Length / 2); i++)
        {
            for (change = 0; i - change >= 0 && i + 1 + change <= sLength - 1; change++)
            {
                if (s[i - change] == s[i + 1 + change])
                    continue;
                break;
            }
            if (((i + change) - (i - change + 1) + 1) > largest.Length)
                largest = Sub(s, i - change + 1, i + change);
        }

        if (sLength >= 3)
            for (int i = 1; i < sLength - 1 - (largest.Length - 1) / 2; i++)
            {
                for (change = 0; i - change >= 0 && i + change <= sLength - 1; change++)
                {
                    if (s[i - change] == s[i + change])
                        continue;
                    break;
                }
                if ((i + change - 1) - (i - change + 1) + 1 > largest.Length)
                    largest = Sub(s, i - change + 1, i + change - 1);
            }
        
        return largest;
    }
}