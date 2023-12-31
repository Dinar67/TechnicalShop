﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
using TechnicalShop.Pages;
using TechnicalShop.Components;

namespace TechnicalShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.mainWindow = this;
            LogoImage.Source = new BitmapImage(new Uri(@"\Resources\pngwing.png", UriKind.Relative));
            MainFrame.Navigate(new ItemList());

        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AuthorizatePage());
        }
    }
}
