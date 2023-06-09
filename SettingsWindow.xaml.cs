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
using System.Windows.Shapes;

namespace Tarneeb
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            MainWindow.PlayGame();
            //Close StartWindow
            this.Close();
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

            mainWindow.Close();

            //Close StartWindow
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameRules window = new GameRules();
            window.Show();
            window.Topmost = true;
        }
    }
}
