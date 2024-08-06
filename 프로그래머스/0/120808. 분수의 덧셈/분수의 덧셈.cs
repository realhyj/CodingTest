using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        
        int max = 0;
    
        int numer=(numer1*denom2)+(numer2*denom1);
        int denom=(denom1*denom2);
    
        for(int i =denom;i>1;i--){
            max = i;
            if(denom%i==0 && numer%max==0){
                answer[0] = numer/max;
                answer[1] = denom/max;
                return answer;
            }
        }
        answer[0]=numer;
        answer[1]=denom;
        return answer;
    }
}