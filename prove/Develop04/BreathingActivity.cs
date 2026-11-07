
public class BreathingActivity : Activity
{
    
    public BreathingActivity() 
    : base(
        "Welcome to the Breathing Activity",
        "This activity will help you relax by walking you through " +
        "breathing in and out slowly. Clear your mind and focus on your breathing."
      )
    {
        
    }

    public void Run()
    {   
        GetStartingMessage();

        int elapsed = 0;
        int duration = GetDuration();

        while(elapsed < duration)
        {
            
            Console.Write("Breathe in. . . ");
            ShowCountDown(5);
            Console.WriteLine();

            Console.Write("Breathe out. . . ");
            ShowCountDown(5);
            Console.WriteLine();

            elapsed += 10;
        }

        DisplayEndingMessage();
    }
}

