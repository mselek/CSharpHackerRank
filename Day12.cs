using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    
    public Student(string Firstname, string Lastname, int i, int[] Testsc )
    {
        firstName = Firstname;
        lastName = Lastname;
        id = i;
        testScores = Testsc;
        
    }
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    
    public char Calculate()
    {
        var sum = 0;
        
        foreach(var score in testScores)
        {
            sum += score;
        }
        
        var avarage = sum / testScores.Length;
        
        if(avarage >= 90)
        {
            return 'O';
        }
        else if(avarage >= 80)
        {
            return 'E';
        }
        else if(avarage >= 70)
        {
            return 'A';
        }
        else if(avarage >= 55)
        {
            return 'P';
        }
        else if(avarage >= 40)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}
