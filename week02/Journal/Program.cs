// I added a feature that displays the total number of journal entries
// so the user can easily see how many entries are currently stored.
Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

bool running = true;

while (running)
{
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");

    string choice = Console.ReadLine();

    Console.WriteLine();

    if (choice == "1")
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;
        entry._entryText = response;

        journal.AddEntry(entry);
    }
    else if (choice == "2")
    {
        Console.WriteLine($"Total journal entries: {journal._entries.Count}");
        Console.WriteLine();

        journal.DisplayAll();
    }
    else if (choice == "3")
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
    else if (choice == "4")
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }
    else if (choice == "5")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter 1-5.");
    }

    Console.WriteLine();
}