using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.DAL
{
    public static class LobbyList
    {
        internal static List<ILobby> lobbyList = new List<ILobby>();

        public static void Add(ILobby lobby)
        {
            lobbyList.Add(lobby);
        }

        static List<ILobby> Getlist => lobbyList;

    }
}
