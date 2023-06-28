using System.Windows.Controls;

using TomoTestDemo.ViewModels;

namespace TomoTestDemo.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}