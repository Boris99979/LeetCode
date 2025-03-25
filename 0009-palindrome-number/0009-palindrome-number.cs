public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        int reverse = 0;
        int original = x;
        while (x != 0)
        {
            int remainder = x % 10;
            reverse = reverse * 10 + remainder;
            x /= 10;
        }
        if (reverse == original)
        {
            return true;
        } else return false;

    }
}