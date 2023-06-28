﻿using System.Windows;
using System.Windows.Controls;

using TomoTestDemo.Contracts.Views;
using TomoTestDemo.ViewModels;

namespace TomoTestDemo.Views
{
    public partial class ShellWindow : Window, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}