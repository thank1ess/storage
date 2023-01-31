public class Solution {
    public int Reverse(int x)
    {
        long output = 0;
        float num = (float)x;

        while (true)
        {
            if (num < 1 && num > -1)
                break;
            num = (float)(num / 10);
            output = (long)(output * 10 + (num - Math.Truncate(num)) * 10);
            num = (float)Math.Truncate(num);
        }

        if (output > int.MaxValue || output < int.MinValue)
            return 0;
        return (int)output;
    }
}