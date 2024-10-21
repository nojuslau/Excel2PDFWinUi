using Excel2PDFWinUi.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Excel2PDFWinUi.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class ExcelFileListPage : Page
{
    public ExcelFileListViewModel ViewModel
    {
        get;
    }

    public ExcelFileListPage()
    {
        ViewModel = App.GetService<ExcelFileListViewModel>();
        InitializeComponent();
    }
}
