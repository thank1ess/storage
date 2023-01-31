public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        else if (x >= 0 & x < 10)
            return true;

        int checker = 0;
        decimal num = x;

        for (byte i = 0; i < 11; i++)
        {
            checker = (int)(checker * 10 + (num / 10 - Math.Truncate(num / 10)) * 10);
            num = Math.Truncate(num / 10);

            if (num < 1)
                break;
        }

        return x == checker ? true : false;
    }
}