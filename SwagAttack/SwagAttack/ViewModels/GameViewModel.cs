using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.DAL;
using SwagAttack.Interfaces;

namespace SwagAttack.ViewModels
{
    class GameViewModel
    {
        public List<IGame> GameListBind => GameList.GamesList;

    }
}
