using System.Windows.Input;
using MvvmFoundation.Wpf;

namespace SwagAttack.ViewModels
{
    public class NavigationViewModel : BaseViewModel
    {
        private static NavigationViewModel ng;
        public static NavigationViewModel NG => ng ?? (ng = new NavigationViewModel());

        private object _selectedViewModel = new UserViewModel();
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged();
            }
        }

        /*private ICommand _lobbyViewCommand;
        public ICommand LobbyViewCommand =>
            _lobbyViewCommand ?? (_lobbyViewCommand = new RelayCommand(
                () =>
                {
                    var current = (UserViewModel) _selectedViewModel;
                    SelectedViewModel = new LobbyViewModel(current.User);
                }));*/

        /*private ICommand _userViewCommand;
        public ICommand UserViewCommand =>
            _userViewCommand ?? (_userViewCommand = new RelayCommand(
                () =>
                {
                    SelectedViewModel = new UserViewModel();
                }));*/
    }
}