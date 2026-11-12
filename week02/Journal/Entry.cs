using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _userAnswer;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_userAnswer}");
        Console.WriteLine();
    }
}