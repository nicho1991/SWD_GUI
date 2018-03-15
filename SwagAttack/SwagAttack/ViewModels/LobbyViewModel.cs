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
    class LobbyViewModel : BaseViewModel<ILobby>
    {

        public List<ILobby> LobbyListBind => LobbyList.lobbyList;

        
    }

}
