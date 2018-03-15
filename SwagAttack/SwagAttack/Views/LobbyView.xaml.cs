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
    /// Interaction logic for LobbyView.xaml
    /// </summary>
    public partial class LobbyView : Page
    {
        public LobbyView()
        {

            InitializeComponent();
            LobbyList.Add(new Lobby());
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void Button_Click(object sender, RoutedEventArgs e)
=======
=======

>>>>>>> parent of c2c8846... fix
        private void LobbyViewList_Loaded(object sender, RoutedEventArgs e)
>>>>>>> c2c8846164c6ec3432a5add83e61b5bcae7197ba
        {
            NavigationService.Navigate(new Uri("Views/PostLogIndView.xaml", UriKind.Relative));
        }
    }
}
