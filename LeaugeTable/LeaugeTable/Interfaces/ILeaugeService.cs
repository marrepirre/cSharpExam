namespace LeaugeTable.Interfaces;

public interface ILeaugeService
{
    Task AddAClubAsync(IClub leaugeTable);
    IEnumerable<IClub> GetAll();
    IClub GetAClub(string Email);
    void DeleteClub(string Email);
}
