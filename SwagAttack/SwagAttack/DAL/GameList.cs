using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Models;

namespace SwagAttack.DAL
{
    static class GameList
    {
        internal static List<Game> GamesList = new List<Game>();

        static void Add(Game game)
        {
            GamesList.Add(game);
        }

        static List<Game> GetMyGames(User user)
        {
            List<Game> tempList = new List<Game>();
            foreach (var VARIABLE in GamesList)
            {
                foreach (var varUser in VARIABLE.UsersInGame)
                {
                    if (varUser == user)
                    {
                        tempList.Add(VARIABLE);
                    }
                }
            }

            return tempList;
        }
    }
}
