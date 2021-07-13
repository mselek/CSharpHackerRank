using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            LetsReview(s);
        }
        
        
    }
    static void LetsReview(string s)
        {
            string evenStr = "";
            string oddStr = "";
            
            for(int i = 0; i < s.Length; i++)
            {
                if(i % 2 == 0)
                {
                    evenStr += s[i];
                }
                else
                {
                    oddStr += s[i];
                }
            }
            
            //Use string interpolation
            Console.WriteLine($"{evenStr} {oddStr}");    
        }
}
 
