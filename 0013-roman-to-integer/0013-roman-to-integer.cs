public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanNum = new Dictionary<char, int>
        {
        {'I', 1}, {'V', 5}, {'X', 10},
            {'L', 50}, {'C', 100},
            {'D', 500}, {'M', 1000}
        };
        int number = 0;
        

        for(int i = 0; i < s.Length; i++)
        {
            
            int curr = romanNum[s[i]];
            int next = (i + 1 < s.Length) ? romanNum[s[i + 1]] : 0;

            number += (curr < next) ? -curr : curr;
        
        } 
        return number;           

    }
   
}