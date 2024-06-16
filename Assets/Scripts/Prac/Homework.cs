using System;
using UnityEngine;

public class Homework : MonoBehaviour
{
    private void Start()
    {
       print( Calculate(""));
    }
    public int Calculate(string s)
    {
        bool IsIncrease = true;
        double sum = 0;
        int onlyNumber = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' || s[i] == '(' || s[i]==')')
            {
                continue;
            }
            if (s[i] == '+')
            {
                IsIncrease = true;
                continue;
            }
            if (s[i] == '-')
            {
                IsIncrease = false;
                continue;
            }
           
            for (int j = i; j < s.Length && Char.IsDigit(s[j]); j++)
            {
                onlyNumber = (onlyNumber * 10) + (s[i] - '0');
                i++;
            }
            i--;
            if (IsIncrease)
            {
                sum += onlyNumber;
            }
            else
            {
                sum -= onlyNumber;
            }
            onlyNumber = 0;
        }
        return Convert.ToInt32(sum);
    }

}


