public class Solution {
    public string IntToRoman(int num)
    {
        short[] decimalNumbers = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        string[] romanNumbers = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        string output = "";

        for (sbyte i = 12; i >= 0 && num != 0;)
        {
            if (num - decimalNumbers[i] >= 0)
            {
                num -= decimalNumbers[i];
                output += romanNumbers[i];
            }
            if (num >= decimalNumbers[i])
                continue;
            i--;
        }

        return output;
    }
}