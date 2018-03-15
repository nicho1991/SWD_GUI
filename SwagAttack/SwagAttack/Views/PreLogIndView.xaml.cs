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

namespace SwagAttack.Views
{
    /// <summary>
    /// Interaction logic for PreLogIndView.xaml
    /// </summary>
    public partial class PreLogIndView : Page
    {
        public PreLogIndView()
        {
            InitializeComponent();
        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/PostLogIndView.xaml", UriKind.Relative));
        }

        private void OpretKont_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/OpreKontoView.xaml", UriKind.Relative));
        }
    }
}
