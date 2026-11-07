using System.Collections.Generic;
public class ReflectionActivity : Activity
{
    
    public ReflectionActivity() 
    : base  (
        "Welcome to the Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience." +
        " This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    {
        
    }

    public void Run()
    {
        GetStartingMessage();

        string[] prompts =
        {
            "---Think of a time when you stood up for someone else.---",
            "---Think of a time when you did something really difficult.---",
            "---Think of a time when you helped someone in need.---",
            "---Think of a time when you did something truly selfless.---"
        };
        
        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        string[] questions =
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        List<string> availableQuestions = new List<string>(questions);

        int elapsed = 0;
        int duration = GetDuration();

        while(elapsed < duration)
        {
            int questionIndex = random.Next(availableQuestions.Count);
            Console.WriteLine(availableQuestions[questionIndex]);

            availableQuestions.RemoveAt(questionIndex);
            ShowSpinner(5);

            elapsed += 5;

            if (availableQuestions.Count == 0)
                {
                    availableQuestions = new List<string>(questions);
                }
        }

        DisplayEndingMessage();



    }
}