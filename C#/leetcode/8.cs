public class Solution {
    public int MyAtoi(string s)
    {
        long output = 0;
        sbyte sign = 1;

        byte[] intDigits = new byte[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        char[] charDigits = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for(byte i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            else if (s[i] == '-' || s[i] == '+')
            {
                sign = s[i] == '-' ? sign = (sbyte)-1 : sign = (sbyte)1;
                if (i + 1 != s.Length && Array.IndexOf(charDigits, s[i + 1]) == -1)
                    return 0;
                continue;
            }
            else if (Array.IndexOf(charDigits, s[i]) != -1)
            {
                for (byte j = i; j < s.Length && Array.IndexOf(charDigits, s[j]) != -1; j++)
                {
                    output = output * 10 + intDigits[Array.IndexOf(charDigits, s[j])];
                    if (output * sign > int.MaxValue) 
                        return int.MaxValue;
                    if (output * sign < int.MinValue)
                        return  int.MinValue;
                }
                break;
            }
            return 0;
        }

        output *= sign;

        if (output > int.MaxValue) output = int.MaxValue;
        if (output < int.MinValue) output = int.MinValue;

        return (int)output;
    }
}