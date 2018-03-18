using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MvvmFoundation.Wpf;
using SwagAttack.DAL;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.ViewModels
{
    public class LobbyViewModel : BaseViewModel
    {

        public IReadOnlyCollection<IUser> UserInLobbyListBind => Lobby.UsersInLobby;

        public IUser User;
        public ILobby Lobby;


        public LobbyViewModel(IUser user, ILobby lobby)
        {
            User = user;
            Lobby = lobby;
        }

        private ICommand _StartSpilCommand;

        public ICommand StartSpilCommand =>
            _StartSpilCommand ?? (_StartSpilCommand = new RelayCommand(
                () =>
                {
                    User.AddAktivtSpil(new Game());
                    var temp = new UserViewModel();
                    temp.User = User;
                    temp.ViewBind = "Post";
                    NavigationViewModel.NG.SelectedViewModel = temp;
                },
                () => (User != null && Lobby != null)));

        private ICommand _AfbrydCommand;

        public ICommand AfbrydCommand =>
            _AfbrydCommand ?? (_AfbrydCommand = new RelayCommand(
                () =>
                {
                    var temp = new UserViewModel();
                    temp.User = User;
                    temp.ViewBind = "Post";
                    NavigationViewModel.NG.SelectedViewModel = temp;
                    
                },
                () => (User != null && Lobby != null)));

        private ICommand _LogUdCommand;

        public ICommand LogUdCommand =>
            _LogUdCommand ?? (_LogUdCommand = new RelayCommand(
                () =>
                {
                    var temp = new UserViewModel();
                    temp.ViewBind = "Pre";
                    NavigationViewModel.NG.SelectedViewModel = temp;

                },
                () => User != null ));
    }

}
