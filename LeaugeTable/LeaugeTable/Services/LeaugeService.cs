using LeaugeTable.Interfaces;
using Newtonsoft.Json;

namespace LeaugeTable.Services;

public class LeaugeService : ILeaugeService
{
    private List<IClub> _clubs = new List<IClub>();
    

    public async Task AddAClubAsync(IClub club)
    {
        _clubs.Add(club);
        var json = JsonConvert.SerializeObject(_clubs);
        await FileService.SaveToFileAsync(json);
    }
    public IClub GetAClub(string email)
    {
        return _clubs.FirstOrDefault(x => x.ClubEmail == email)!;
    }

    public IEnumerable<IClub> GetAll()
    {
        return _clubs;
    }

    public void DeleteClub(string email)
    {
        var club = GetAClub(email);
        _clubs.Remove(club);
    }
}
