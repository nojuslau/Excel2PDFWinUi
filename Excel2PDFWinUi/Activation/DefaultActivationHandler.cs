using Excel2PDFWinUi.Contracts.Services;
using Excel2PDFWinUi.ViewModels;

using Microsoft.UI.Xaml;

namespace Excel2PDFWinUi.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;

    public DefaultActivationHandler(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame?.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        _navigationService.NavigateTo(typeof(CompanyListViewModel).FullName!, args.Arguments);

        await Task.CompletedTask;
    }
}
