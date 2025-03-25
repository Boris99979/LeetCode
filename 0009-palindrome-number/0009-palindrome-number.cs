public class Solution {
    public bool IsPalindrome(int x) {
        int reverse = 0, original = x;
        while (original > 0)
        {   
            reverse = reverse * 10 + original % 10;
            original /= 10;
        }

        return x == reverse;
       
    }
}