using System.Collections.Generic;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using TomoTestDemo.Core.Models;

namespace TomoTestDemo.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RunCommand))]
        private string _left = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RunCommand))]
        private string _right = string.Empty;

        [ObservableProperty]
        private string _result = string.Empty;

        [ObservableProperty]
        private IEnumerable<string> _symbols;

        [ObservableProperty]
        private string _selectedValue = string.Empty;

        private bool _isStringToIntParse => (int.TryParse(Left, out _) && int.TryParse(Right, out _));

        [RelayCommand(CanExecute = nameof(_isStringToIntParse))]
        public void Run()
        {
            var left = int.Parse(Left);
            var right = int.Parse(Right);
            Result = _calculation.Run(SelectedValue, left, right).ToString();
        }

        private readonly ICalculation _calculation;

        public MainViewModel(ICalculation calculation)
        {
            _calculation = calculation;

            _symbols = _calculation.Symbols;
        }
    }
}