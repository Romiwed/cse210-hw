// EXCEEDING REQUIREMENTS:
// I added a counter that keeps track of how many mindfulness
// activities the user completes during the current session.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int activitiesCompleted = 0;

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.WriteLine($"Activities completed this session: {activitiesCompleted}");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                activitiesCompleted++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                activitiesCompleted++;
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                activitiesCompleted++;
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine($"You completed {activitiesCompleted} activities this session.");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please choose a number from 1 to 4.");
                Thread.Sleep(1500);
            }
        }
    }
}