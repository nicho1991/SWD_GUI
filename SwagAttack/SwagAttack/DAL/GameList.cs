using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.DAL
{
    static class GameList
    {
        internal static List<IGame> GamesList = new List<IGame>();

        public static void Add(IGame game)
        {
            GamesList.Add(game);
        }

        static List<IGame> GetMyGames(IUser user)
        {
            List<IGame> tempList = new List<IGame>();
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

        static void Remove(IGame game)
        {
            GamesList.Remove(game);
        }


    }
}
