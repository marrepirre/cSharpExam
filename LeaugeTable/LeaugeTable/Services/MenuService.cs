using LeaugeTable.Interfaces;
using LeaugeTable.Models;

namespace LeaugeTable.Services;

public class MenuService
{
    private static readonly ILeaugeService leaugeService = new LeaugeService();

    public static void AddClubMenu()
    {
        IClub club = new ClubInfo();    
        Console.Write("Clubs name: ");
        club.ClubName = Console.ReadLine();
        Console.Write("Clubs city: ");
        club.ClubCity = Console.ReadLine();
        Console.Write("Clubs Color: ");
        club.ClubColor = Console.ReadLine();
        Console.Write("Clubs email: ");
        club.ClubEmail = Console.ReadLine();

        Task.Run(() => leaugeService.AddAClubAsync(club));
    }
    public static void ViewAllClubs() 
    { 
        foreach (var clubs in leaugeService.GetAll())
        {
            Console.WriteLine(clubs.ClubInformation);
            Console.WriteLine();
        }    
    
    }
    public static void ViewOneClub()
    {
        Console.Write("Skriv in klubbens epost: ");
        var email = Console.ReadLine();
        var club = leaugeService.GetAClub(email!);

        Console.WriteLine(club!.ClubInformation);
    }
    public static void RemoveClubMenu() 
    {
        Console.WriteLine("Skriv klubbens Epost: ");
        var email = Console.ReadLine();
        leaugeService.DeleteClub(email!);
    }

    public static void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("1. Lägg till en klubb i din liga: ");
            Console.WriteLine("2. Visa alla klubbar i din liga: ");
            Console.WriteLine("3. Visa en specifik klubb: ");
            Console.WriteLine("4. Ta bort en klubb: ");
            Console.Write("Vilken meny vill du gå till: ");
            var option = Console.ReadLine();

            Console.Clear();
            switch (option)
            {
                case "1":
                    AddClubMenu();
                    break;
                case "2":
                    ViewAllClubs();
                    break;
                case "3":
                    ViewOneClub();
                    break;
                case "4":
                    RemoveClubMenu();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            } 
            Console.ReadKey();

        }while (true);
    }
}
