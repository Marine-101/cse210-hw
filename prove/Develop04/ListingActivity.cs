public class ListingActivity : Activity
{
    public ListingActivity()
        : base(
            "Welcome to the Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can."
        )
    {
        
    }

    public void Run()
    {
        GetStartingMessage();

        string[] prompts =
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(prompts[index]);

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.Write("you may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        int count = 0;

        int elapsed = 0;
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        
        while (elapsed < duration)
        {
            Console.ReadLine();
            count++;

            elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }
        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage();
    }
}