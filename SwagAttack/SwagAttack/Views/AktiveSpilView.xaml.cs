using System;
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
using SwagAttack.DAL;
using SwagAttack.Models;

namespace SwagAttack.Views
{
    /// <summary>
    /// Interaction logic for AktiveSpilView.xaml
    /// </summary>
    public partial class AktiveSpilView : Page
    {
        public AktiveSpilView()
        {
            InitializeComponent();
        }

        private void StartSpil_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views/PostLogIndView.xaml", UriKind.Relative));
        }

        private void Afbryd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views/PostLogIndView.xaml", UriKind.Relative));
        }

        private void Logud_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views/PreLogIndView.xaml", UriKind.Relative));
        }

        private void GameViewList_OnLoadedViewList_Loaded(object sender, RoutedEventArgs e)
        {
            GameList.Add(new Game()); // just for test

            foreach (var VARIABLE in GameList.GamesList)
            {
                GameViewList.Items.Add(VARIABLE);
            }
        }
    }
}
