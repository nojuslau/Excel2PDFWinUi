using CommunityToolkit.WinUI.UI.Controls;

using Excel2PDFWinUi.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Excel2PDFWinUi.Views;

public sealed partial class CompanyDetailsPage : Page
{
    public CompanyDetailsViewModel ViewModel
    {
        get;
    }

    public CompanyDetailsPage()
    {
        ViewModel = App.GetService<CompanyDetailsViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
