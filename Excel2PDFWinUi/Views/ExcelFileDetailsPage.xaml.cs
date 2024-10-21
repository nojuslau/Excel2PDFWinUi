using Excel2PDFWinUi.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Excel2PDFWinUi.Views;

public sealed partial class ExcelFileDetailsPage : Page
{
    public ExcelFileDetailsViewModel ViewModel
    {
        get;
    }

    public ExcelFileDetailsPage()
    {
        ViewModel = App.GetService<ExcelFileDetailsViewModel>();
        InitializeComponent();
    }
}
