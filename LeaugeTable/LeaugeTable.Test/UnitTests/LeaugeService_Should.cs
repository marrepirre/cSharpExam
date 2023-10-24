using LeaugeTable.Interfaces;
using LeaugeTable.Models;
using LeaugeTable.Services;

namespace LeaugeTable.Test.UnitTests;

public class LeaugeService_Should
{
    [Fact]
    public void AddClub_Should_AddAClubToList_ReturnTrue()
    {
        //Arrange
        ILeaugeService leaugeService = new LeaugeService();
        IClub club = new ClubInfo();

        //Act
        club.ClubName = "Wolves";
        club.ClubCity = "Wolverhampton";
        club.ClubEmail = "Forza@Wolves.com";
        leaugeService.AddAClubAsync(club);

        Task result = leaugeService.AddAClubAsync(club);

        //Assert
        Assert.ThrowsAnyAsync<Exception>(() => result);
    }

    [Fact]
    public void GetAllClub_Should_GetAListOfClubs_ReturnOneClub()
    {
        //Arrange
        ILeaugeService leaugeService = new LeaugeService();
        IClub club = new ClubInfo();
        club.ClubName = "Wolves";
        club.ClubCity = "Wolverhampton";
        club.ClubColor = "Black and Yellow";
        club.ClubEmail = "Forza@Wolves.com";
        leaugeService.AddAClubAsync(club);

        //Act
        IEnumerable<IClub> result = leaugeService.GetAll();

        //Assert
        Assert.NotNull(result);
        Assert.Single(result);
    }
}
