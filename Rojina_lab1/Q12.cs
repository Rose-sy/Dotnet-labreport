using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of marks:");
        int numMarks = int.Parse(Console.ReadLine());
        
        if (numMarks <= 0)
        {
            Console.WriteLine("Number of marks must be greater than zero.");
            return;
        }
        
        int[] marks = new int[numMarks];
        
        for (int i = 0; i < numMarks; i++)
        {
            Console.WriteLine("Enter mark {0}:", i + 1);
            marks[i] = int.Parse(Console.ReadLine());
        }
        
        int minMark = marks[0];
        int maxMark = marks[0];
        int totalMarks = 0; // Initialize totalMarks to 0
        
        for (int i = 0; i < numMarks; i++)
        {
            if (marks[i] < minMark)
            {
                minMark = marks[i];
            }
            if (marks[i] > maxMark)
            {
                maxMark = marks[i];
            }
            totalMarks += marks[i];
        }
        
        double averageMark = (double)totalMarks / numMarks;
        
        Console.WriteLine("\nMinimum mark: {0}", minMark);
        Console.WriteLine("Maximum mark: {0}", maxMark);
        Console.WriteLine("Average mark: {0:0.00}", averageMark);
    }
}
