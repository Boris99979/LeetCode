//Just a test case for optimization, not my real answer

public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        int len = s.Length;

        for (int i = 0; i < len; i++) {
            int curr = GetValue(s[i]);
            int next = (i + 1 < len) ? GetValue(s[i + 1]) : 0;

            if (curr < next)
                total -= curr;
            else
                total += curr;
        }

        return total;
    }

    private static int GetValue(char c) => c switch {
        'I' => 1, 'V' => 5, 'X' => 10,
        'L' => 50, 'C' => 100, 'D' => 500, 'M' => 1000,
        _ => 0
    };
}
