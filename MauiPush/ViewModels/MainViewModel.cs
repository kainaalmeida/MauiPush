using OneSignalSDK.DotNet;

namespace MauiPush.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private Guid _externalId = Guid.Parse("428F82C4-40C9-45E2-90B6-2F939375E03A");
    [RelayCommand]
    public void AddExternalId()
    {
        OneSignal.Login(_externalId.ToString());
    }
}
