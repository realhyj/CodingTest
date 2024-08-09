using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer =new string[strings.Length];
        
        for(int i = 0; i< strings.Length;i++){
            answer[i] = (strings[i][n])+strings[i];
        }
        
        Array.Sort(answer);
        
        for(int h = 0; h< strings.Length; h++){
            answer[h] = answer[h].Substring(1);
        }
        
        return answer;
    }
}