using System.Windows.Input;
using MvvmFoundation.Wpf;

namespace SwagAttack.ViewModels
{
    public class NavigationViewModel : BaseViewModel
    {
        private object _selectedViewModel = new UserViewModel();
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                if (_selectedViewModel != _selectedViewModel)
                {
                    _selectedViewModel = value;
                    OnPropertyChanged();
                }
            }
        }

        private ICommand _lobbyViewCommand;
        public ICommand LobbyViewCommand =>
            _lobbyViewCommand ?? (_lobbyViewCommand = new RelayCommand(
                () =>
                {
                    var current = (UserViewModel) _selectedViewModel;
                    SelectedViewModel = new LobbyViewModel(current.User);
                }));

        private ICommand _userViewCommand;
        public ICommand UserViewCommand =>
            _userViewCommand ?? (_userViewCommand = new RelayCommand(
                () =>
                {
                    SelectedViewModel = new UserViewModel();
                }));
    }
}