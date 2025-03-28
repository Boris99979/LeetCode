public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         string result = "";
         for(int i = 0; i < strs[0].Length; i++)
         {
            char c = strs[0][i];
            for(int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || c != strs[j][i])
                {
                    return result;
                }
            }
            result += c;
         }
         return result;
    }
}