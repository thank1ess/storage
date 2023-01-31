public class Solution {
    public string Convert(string s, int rows)
    {
        if (rows == 1) 
            return s;

        short sLength = (short)s.Length;
        char[] b = new char[sLength];
        short[] indexes = new short[sLength];
        sbyte change = 1;

        for (short i = 0, tIndex = 0; i < sLength; i++)
        {
            indexes[i] = tIndex;
            tIndex += change;

            if (tIndex == 0 || tIndex == rows - 1) 
                change = (sbyte)(-change);
        }

        for (short i = 0, index = 0; i < rows && index < sLength; i++)
            for (short j = 0; j < sLength; j++)
                if (indexes[j] == i)
                    b[index++] = s[j];

        return new string(b);
    }
}