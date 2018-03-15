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
    class UserViewModel : BaseViewModel
    {
        private IUser _user = null;

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
                _user = user;
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
                        _user = user;
                    }
                },
                () => 
                    (Username != null && Password != null)));

        private ICommand _createLobbyCommand;

        public ICommand CreateLobbyCommand =>
            _createLobbyCommand ?? (_createLobbyCommand = new RelayCommand(
                () =>
                {
                    var lobby = _user.CreateLobby();
                    LobbyList.Add(lobby);
                },
                () => _user != null));

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
