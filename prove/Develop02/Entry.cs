public class Entry
{
    public string _date;
    public string _prompt;
    public string _responce;

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_responce);
    }
}
