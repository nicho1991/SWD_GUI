using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmFoundation.Wpf;
using SwagAttack.DAL;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public IUser User = null;

        public IUser UserBind
        {
            get { return User; }
           
        }

        private string _ViewBind = "Pre";

        public string ViewBind
        {
            get { return _ViewBind;}
            set
            {
                _ViewBind = value;
                OnPropertyChanged();
            }
        }

        public IReadOnlyCollection<IGame> GameListBind
        {
            get { return User.AktiveSpilListe; }

        }

        #region Commands

        private ICommand _createUserCommand;

        public ICommand CreateUserCommand =>
            _createUserCommand ?? (_createUserCommand = new RelayCommand(CreateUser_Execute, CreateUser_CanExecute));

        private void CreateUser_Execute()
        {
            var user = new User
            {
                Email = this.Email,
                Password = this.Password,
                Username = this.Username
            };

            if (UserList.Add(user))
            {
                //User = user;
                //OnPropertyChanged("User");
                ViewBind = "Pre";
            }

        }

        private bool CreateUser_CanExecute()
        {
            return (Username != null && Password != null && Email != null);
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new RelayCommand(()
                =>
                {
                    var user = UserList.FindUser(Username);
                    if (user?.Password == Password)
                    {
                        User = user;
                        ViewBind = "Post";
                        OnPropertyChanged("User");
                        OnPropertyChanged("UserBind");
                    }
                },
                () =>(Username != null && Password != null)));

        private ICommand _createLobbyCommand;

        public ICommand CreateLobbyCommand =>
            _createLobbyCommand ?? (_createLobbyCommand = new RelayCommand(
                () =>
                {
                    var lobby = User.CreateLobby();
                    lobby.AddUser(User);
                    NavigationViewModel.NG.SelectedViewModel = new LobbyViewModel(User, lobby);

                    LobbyList.Add(lobby);
                },
                () => User != null));

        private ICommand _OpretKontoPressedCommand;

        public ICommand OpretKontoPressedCommand =>
            _OpretKontoPressedCommand ?? (_OpretKontoPressedCommand = new RelayCommand(
                () =>
                    {
                        ViewBind = "Opret";
                    }, () => true));

        private ICommand _AfbrydOpretKontoPressedCommand;

        public ICommand AfbrydOpretKontoPressedCommand =>
            _AfbrydOpretKontoPressedCommand ?? (_AfbrydOpretKontoPressedCommand = new RelayCommand(
                () =>
                {
                    ViewBind = "Pre";
                }, () => true));

        private ICommand _AfbrydPressedCommand;

        public ICommand AfbrydPressedCommand =>
            _AfbrydPressedCommand ?? (_AfbrydPressedCommand = new RelayCommand(
                () =>
                {
                    ViewBind = "Post";
                }, () => true));



        private ICommand _LogUdPressedCommand;

        public ICommand LogUdPressedCommand =>
            _LogUdPressedCommand ?? (_LogUdPressedCommand = new RelayCommand(
                () =>
                {
                    ViewBind = "Pre";
                }, () => true));

        private ICommand _AktiveSpilPressedCommand;

        public ICommand AktiveSpilPressedCommand =>
            _AktiveSpilPressedCommand ?? (_AktiveSpilPressedCommand = new RelayCommand(
                () =>
                {
                    ViewBind = "Aktiv";
                }, () => true));

        #endregion


        #region Properties

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _email;

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

    }
}
