using Excel2PDFWinUi.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Excel2PDFWinUi.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class PDFFileListPage : Page
{
    public PDFFileListViewModel ViewModel
    {
        get;
    }

    public PDFFileListPage()
    {
        ViewModel = App.GetService<PDFFileListViewModel>();
        InitializeComponent();
    }
}
