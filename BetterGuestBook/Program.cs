using GuestBookLibrary.Models;

//Ask for guest info (first Name, last name, length of stay in days)
//store guest info in list
//loop thorugh list
string moreGuests = string.Empty;
bool isInt;

List<GuestModel> guests = new List<GuestModel>();

do
{
    GuestModel guest = new GuestModel();

    GetGuestInfo(guest);

    IntCheck(guest);

    Console.Write("Any more guests (yes/no): ");
    moreGuests = Console.ReadLine().ToLower();

    guests.Add(guest);

    Console.Clear();

} while (moreGuests == "yes");


foreach (GuestModel guest in guests)
{
	Console.WriteLine(guest.GuestInfo);
}

static void IntCheck(GuestModel guest)
{
    int days;
    bool isInt;
    do
    {
        isInt = int.TryParse(Console.ReadLine(), out days);
        if (!isInt)
        {
            Console.Write("Invalid amount of days, please try again: ");
        }
        else
        {
            guest.LengthOfStayInDays = days;
        }
    } while (!isInt);
}

static void GetGuestInfo(GuestModel guest)
{
    
    guest.FirstName = GetInfoFromConsole("What is your first name: ");
    guest.LastName = GetInfoFromConsole("What is your last name: ");
    Console.Write("How many days will you be staying: ");
}

static string GetInfoFromConsole(string message)
{
    string output = string.Empty;

    Console.Write($"{message}");
    output= Console.ReadLine();

    return output;
}
