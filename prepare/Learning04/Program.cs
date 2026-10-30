using System;

class Program
{
    static void Main(string[] args)
    {
  
        Assignment a1 = new Assignment("Gunnar Bird", "Multiplication");
        Console.WriteLine(a1.GetSummary());

  
        MathAssignment a2 = new MathAssignment("Clancy Bird", "Fractions", "3.4", "5-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Livy Bird", "WW II", "What caused world war 2");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}