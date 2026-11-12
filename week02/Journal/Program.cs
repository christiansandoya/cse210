using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string userAnswer = Console.ReadLine();
                    
                    // =========================================================================
                    // EXCEEDING REQUIREMENTS:
                    // Instead of storing only the short date (ToShortDateString), DateTime.Now
                    // with full formatting ("g" – short date and time) is used to record the 
                    // exact moment the journal entry was written.
                    // =========================================================================
                    string dateText = DateTime.Now.ToString("g");

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._userAnswer = userAnswer;

                    theJournal.AddEntry(newEntry);
                    break;
                    // =========================================================================

                case 2:
                    Console.WriteLine("\n--- Journal Entries ---");
                    theJournal.DisplayAll();
                    break;

                case 3:
                    Console.Write("\nWhat is the filename? ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case 4:
                    Console.Write("\nWhat is the filename? ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case 5:
                    Console.WriteLine("\nGoodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please select a number between 1 and 5.");
                    break;
            }
        }
    }
}