using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int max = 0;
        int maxCount = 0;
        int maxAry = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxAry)
        {
            maxAry = array[i];
        }
    }
        
  int[] index = new int[maxAry + 1];
        
        for(int i =0; i < array.Length; i++)
        {
            index[array[i]]++;
        }
        for(int i = 0; i<index.Length; i++)
        {
            if(index[i]>max)
            {
                max = index[i];
                answer = i;
                maxCount = 1;
            }
            else if(index[i] == max)
            {
                maxCount++;
            }
        }
        if(maxCount > 1)
        {
            answer = -1;
        }
        
        return answer;
    }
}