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
    /// Interaction logic for OpreKontoView.xaml
    /// </summary>
    public partial class OpreKontoView : Page
    {
        public OpreKontoView()
        {
            InitializeComponent();
        }

        private void Afbryd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/PostLogIndView.xaml", UriKind.Relative));
        }

        private void OpretKonto_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Views/PostLogIndView.xaml", UriKind.Relative));
        }
    }
}
