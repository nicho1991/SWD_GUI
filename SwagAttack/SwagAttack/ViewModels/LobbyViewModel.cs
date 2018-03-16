using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SwagAttack.DAL;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.ViewModels
{
    public class LobbyViewModel : BaseViewModel
    {
        public List<ILobby> LobbyListBind => LobbyList.lobbyList;

        public IReadOnlyCollection<IUser> Users
    }

}
