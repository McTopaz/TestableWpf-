﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WpfApp.ViewModels;
using WpfApp.Views;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = new ViewModels.MainWindowViewModel();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.Output = vm.Input;
        }

        private void Window1_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window1();
            window.Show();
        }

        private void ComboBox_Click(object sender, RoutedEventArgs e)
        {
            var window = new ComboBoxWindow();
            var vm = new ComboBoxViewModel();

            vm.Fruits = new List<string> { "Banana", "Pear", "Lemon", "Apple" };
            window.DataContext = vm;
            window.Show();
        }

        private void UserControl1_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.Content = new UserControl1();
            window.Show();
        }

        private void DialogWindow_Click(object sender, RoutedEventArgs e)
        {
            var def = txtDialogWindowText.Text;
            var viewModel = new DialogWindowViewModel(def);
            var window = new DialogWindow();
            window.DataContext = viewModel;
            window.ShowDialog();
            txtDialogWindowText.Text = viewModel.Value;
        }
    }
}
