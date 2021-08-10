using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] arr)
    {
        elements = arr; 
    } 
    
    public void computeDifference()
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        
        for(var i = 0; i < elements.Length; i++)
        {
            min = Math.Min(min, elements[i]);
            max = Math.Max(max, elements[i]);
        }
        
        maximumDifference = max - min;
    }  

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
