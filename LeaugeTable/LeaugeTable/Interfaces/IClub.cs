namespace LeaugeTable.Interfaces;

public interface IClub
{

    string? ClubName { get; set; }
    string? ClubCity { get; set; }
    string? ClubColor { get; set; }
    string? ClubEmail { get; set;}

    string? ClubInformation { get; }
}
