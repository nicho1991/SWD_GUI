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
using SwagAttack.DAL;

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
        }

        private void ListViewItem_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var VARIABLE in LobbyList.lobbyList)
            {
                LobbyViewList.Items.Add(VARIABLE);
            }
        }
    }
}
