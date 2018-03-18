using System.Collections.Generic;
using System.Linq.Expressions;
using SwagAttack.DAL;
using SwagAttack.Interfaces;

namespace SwagAttack.Models
{
    public class Lobby : ILobby
    {
        private readonly List<IUser> _usersInLobby = new List<IUser>();
        public IReadOnlyCollection<IUser> UsersInLobby => _usersInLobby;
        public void AddUser(IUser user)
        {
            if(!_usersInLobby.Contains(user))
                _usersInLobby.Add(user);
        }

        public void RemoveUser(IUser user)
        {
            if (_usersInLobby.Contains(user))
                _usersInLobby.Remove(user);
        }

        public IGame StartGame()
        {
            var game = new Game();
            foreach (var user in _usersInLobby)
            {
                game.AddUser(user);
            }

	        GameList.Add(game);
            return game;
        }
    }
}