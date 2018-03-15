using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Models;

namespace SwagAttack.DAL
{
    static class LobbyList
    {
        internal static List<Lobby> lobbyList = new List<Lobby>();

        static void Add(Lobby lobby)
        {
            lobbyList.Add(lobby);
        }

        static List<Lobby> Getlist => lobbyList;

        static void Remove(Lobby lobby)
        {
            lobbyList.Remove(lobby);
        }

    }
}
