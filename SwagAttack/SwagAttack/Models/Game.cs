using System.Collections.Generic;
using SwagAttack.Interfaces;

namespace SwagAttack.Models
{
    public class Game : IGame
    {
        private readonly List<IUser> _usersInGame = new List<IUser>();
        public IReadOnlyCollection<IUser> UsersInGame => _usersInGame;
        public void AddUser(IUser user)
        {
            if(!_usersInGame.Contains(user))
                _usersInGame.Add(user);
        }

        public void RemoveUser(IUser user)
        {
            if (_usersInGame.Contains(user))
                _usersInGame.Remove(user);
        }
    }
}