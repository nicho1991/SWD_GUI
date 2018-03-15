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

namespace SwagAttack.Views
{
    /// <summary>
    /// Interaction logic for PostLogIndView.xaml
    /// </summary>
    public partial class PostLogIndView : Page
    {
        public PostLogIndView()
        {
            InitializeComponent();
        }

        private void Logud_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/PreLogIndView.xaml", UriKind.Relative));
        }

        private void MineAktiveSpil_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/AktiveSpilView.xaml", UriKind.Relative));
        }

        private void TilslutLobby_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/LobbyView.xaml", UriKind.Relative));
        }

        private void OpretLobby_OnClick(object sender, RoutedEventArgs e)
        {
           //penis
        }
    }
}
