public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanNum = new();
        romanNum.Add('I', 1);
        romanNum.Add('V', 5);
        romanNum.Add('X', 10);
        romanNum.Add('L', 50);
        romanNum.Add('C', 100);
        romanNum.Add('D', 500);
        romanNum.Add('M', 1000);

        int number = 0;
        char[] romanChar = s.ToCharArray();

        for(int i = 0; i < romanChar.Length; i++)
        {
            
            int curr = romanNum[romanChar[i]];
            int next = (i + 1 < romanChar.Length) ? romanNum[romanChar[i + 1]] : 0;

            number += (curr < next) ? -curr : curr;
        
        } 
        return number;           

    }
   
}