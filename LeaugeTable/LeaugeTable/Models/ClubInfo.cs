using LeaugeTable.Interfaces;

namespace LeaugeTable.Models;

public class ClubInfo : IClub
{
    public string? ClubName { get; set; }
    public string? ClubCity { get; set; }
    public string? ClubColor { get; set; }
    public string? ClubEmail { get; set; } 

    public string? ClubInformation => $"Club name: {ClubName} City of the club: {ClubCity} ClubsColors: {ClubColor} Admins email <{ClubEmail}>";
}
