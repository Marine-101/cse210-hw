using System.Threading;
public class Activity
{
    private string _name;
    private string _description; 
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void GetStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

    }

    public int GetDuration()
    {
    return _duration;
    }   

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] animation = { "-", "\\", "|", "/"};

        for (int i = 0; i < seconds * 4; i++)
        {
            
            Console.Write(animation[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}