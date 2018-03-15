using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Models;

namespace SwagAttack.DAL
{
    public static class LobbyList
    {
        internal static List<Lobby> lobbyList = new List<Lobby>();

        public static void Add(Lobby lobby)
        {
            lobbyList.Add(lobby);
        }

        public static List<Lobby> Getlist => lobbyList;

        public static void Remove(Lobby lobby)
        {
            lobbyList.Remove(lobby);
        }

    }
}
