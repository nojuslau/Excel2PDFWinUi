using Excel2PDFWinUi.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Excel2PDFWinUi.Views;

public sealed partial class PDFFileDetailsPage : Page
{
    public PDFFileDetailsViewModel ViewModel
    {
        get;
    }

    public PDFFileDetailsPage()
    {
        ViewModel = App.GetService<PDFFileDetailsViewModel>();
        InitializeComponent();
    }
}
