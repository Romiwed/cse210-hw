// For creativity, I made the program only hide words that are still visible.
// This way, it does not choose the same hidden words again.
Reference reference = new Reference("Proverbs", 3, 5, 6);

string text =
    "Trust in the Lord with all thine heart and lean not unto thine own understanding; " +
    "in all thy ways acknowledge him, and he shall direct thy paths.";

Scripture scripture = new Scripture(reference, text);

while (!scripture.IsCompletelyHidden())
{
    Console.Clear();

    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();
    Console.WriteLine("Press enter to continue or type 'quit' to finish:");

    string input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        break;
    }

    scripture.HideRandomWords(3);
}

if (scripture.IsCompletelyHidden())
{
    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
}