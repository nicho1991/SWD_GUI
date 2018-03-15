using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmFoundation.Wpf;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.ViewModels
{
    class UserViewModel : BaseViewModel<IUser>
    {
        private ICommand _createUserCommand;

        public ICommand CreateUserCommand =>
            _createUserCommand ?? (_createUserCommand = new RelayCommand<string[]>(CreateUser_Execute));
        private void CreateUser_Execute(string[] array)
        {
            if (array.Length != 3)
                return;

            var username = array[0];
            var password = array[1];
            var email = array[2];

            var user = new User
            {
                Email = email,
                Password = password,
                Username = username
            };

            Add(user);
        }

        private ICommand _createLobbyCommand;

    }
}
