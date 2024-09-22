using CarJournal.Domain;
using CarJournal.Services.Authentication;
using CarJournal.Services.Cars;
using CarJournal.Services.Client;
using CarJournal.Services.UserCars;

using Microsoft.AspNetCore.Components;

namespace CarJournal.Pages.UserPages.MainPages;

public class MainPageViewModel
{
    private readonly IUserCarsService _userCarsService;
    private readonly IClientAuthenticationService _authenticationService;
    private readonly ISelectedCarService _selectedCarService;
    public UserCar? SelectedCar { get; set; }
    public List<UserCar> UserCars { get; set; } = new();

    public MainPageViewModel(IUserCarsService userCarService,
                             IClientAuthenticationService authenticationService,
                             ISelectedCarService selectedCarService)
    {
        _userCarsService = userCarService;
        _authenticationService = authenticationService;
        _selectedCarService = selectedCarService;
    }

    public async Task LoadUserCarsAsync()
    {
        var userIdString = await _authenticationService.GetUserIdAsync();

        if(userIdString == null)
        {
            throw new Exception("No authorized (load user cars)");
        }

        UserCars = await _userCarsService.GetAllAsync(Convert.ToInt32(userIdString));
    }

    public async void OnSelectedCarChanged(UserCar userCar)
    {
        SelectedCar = userCar;

        await _selectedCarService.SetSelectedCarId(userCar.Id);
    }

    public async Task<IEnumerable<UserCar>> SearchCar(string value, CancellationToken token)
    {
        await Task.Delay(5, token);

        if (string.IsNullOrEmpty(value))
            return UserCars;

        return UserCars.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }
}